﻿using System.Collections.Generic;
using System.Collections.Immutable;
using System.Globalization;
using System.Text.RegularExpressions;

using Microsoft.Recognizers.Definitions.Japanese;
using Microsoft.Recognizers.Text.NumberWithUnit.Japanese;
using Microsoft.Recognizers.Text.NumberWithUnit;

using DateObject = System.DateTime;

namespace Microsoft.Recognizers.Text.DateTime.Japanese
{
    public class DurationExtractor : BaseDateTimeExtractor<DurationType>
    {
        internal override ImmutableDictionary<Regex, DurationType> Regexes { get; }

        protected sealed override string ExtractType { get; } = Constants.SYS_DATETIME_DURATION; // "Duration";

        private static readonly IExtractor InternalExtractor = new NumberWithUnitExtractor(new DurationExtractorConfiguration());

        private static readonly Regex YearRegex = new Regex(DateTimeDefinitions.DurationYearRegex, RegexOptions.Singleline);

        private static readonly Regex HalfSuffixRegex = new Regex(DateTimeDefinitions.DurationHalfSuffixRegex, RegexOptions.Singleline);

        // extract by number with unit
        public override List<ExtractResult> Extract(string source, DateObject referenceTime)
        {
            //Use Unit to extract 
            var retList = InternalExtractor.Extract(source);
            var res = new List<ExtractResult>();
            foreach (var ret in retList)
            {
                //filter
                var match = YearRegex.Match(ret.Text);
                if (match.Success)
                {
                    continue;
                }

                // match suffix "半"
                var suffix = source.Substring((int)(ret.Start + ret.Length));
                var beginMatch = HalfSuffixRegex.MatchBegin(suffix, trim: true);

                if (beginMatch.Success)
                {
                    var matchString = suffix.Substring(beginMatch.Index, beginMatch.Length);
                    ret.Text = ret.Text + matchString;
                    ret.Length = ret.Length + beginMatch.Length;
                }

                res.Add(ret);
            }
            return res;
        }

        internal class DurationExtractorConfiguration : JapaneseNumberWithUnitExtractorConfiguration
        {
            public DurationExtractorConfiguration() : base(new CultureInfo("zh-CN")) { }

            public override ImmutableDictionary<string, string> SuffixList => DurationSuffixList;

            public override ImmutableDictionary<string, string> PrefixList => null;

            public override string ExtractType => Constants.SYS_DATETIME_DURATION;

            public static readonly ImmutableDictionary<string, string> DurationSuffixList = DateTimeDefinitions.DurationSuffixList.ToImmutableDictionary();

            public override ImmutableList<string> AmbiguousUnitList => DateTimeDefinitions.DurationAmbiguousUnits.ToImmutableList();
        }
    }

    public enum DurationType
    {
        WithNumber
    }
}