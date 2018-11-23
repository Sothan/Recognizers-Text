﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
//     
//     Generation parameters:
//     - DataFilename: Patterns\German\German-DateTime.yaml
//     - Language: German
//     - ClassName: DateTimeDefinitions
// </auto-generated>
//------------------------------------------------------------------------------
namespace Microsoft.Recognizers.Definitions.German
{
	using System;
	using System.Collections.Generic;

	public static class DateTimeDefinitions
	{
		public const string TillRegex = @"(?<till>zu|bis\s*zum|zum|bis|bis\s*hin(\s*zum)?|--|-|—|——)";
		public const string RangeConnectorRegex = @"(?<and>und|--|-|—|——)";
		public const string RelativeRegex = @"(?<order>nächst(er|en|es|e)|kommend(er|en|es|e)|dies(er|em|en|es|e)|letzt(er|en|es|e)|vergangen(er|en|es|e)|vorherig(er|en|es|e)|vorig(er|en|es|e)|dies(er|en|es|e)|jetzig(er|en|es|e)|nach)";
		public const string StrictRelativeRegex = @"(?<order>nächst(er|en|es|e)|kommend(er|en|es|e)|dies(er|em|en|es|e)|letzt(er|en|es|e)|vergangen(er|en|es|e)|vorherig(er|en|es|e)|vorig(er|en|es|e)|dies(er|en|es|e)|jetzig(er|en|es|e)|nach)";
		public const string NextPrefixRegex = @"(nächst(er|en|es|e)|kommend(er|en|es|e))";
		public const string PastPrefixRegex = @"(letzt(er|en|es|e)|vergangen(er|en|es|e)|vorherig(er|en|es|e)|vorig(er|en|es|e)|vor|nach)";
		public const string ThisPrefixRegex = @"(dies(er|en|em|es|e)|jetzig(er|en|es|e))";
		public const string DayRegex = @"((der|dem|des)\s*)?(?<day>(01|02|03|04|05|06|07|08|09|10|11|12|13|14|15|16|17|18|19|1|20|21|22|23|24|25|26|27|28|29|2|30|31|3|4|5|6|7|8|9))(\.)?";
		public const string MonthNumRegex = @"(?<month>01([\.])?|02([\.])?|03([\.])?|04([\.])?|05([\.])?|06([\.])?|07([\.])?|08([\.])?|09([\.])?|10([\.])?|11([\.])?|12([\.])?|1([\.])?|2([\.])?|3([\.])?|4([\.])?|5([\.])?|6([\.])?|7([\.])?|8([\.])?|9([\.])?)\b";
		public static readonly string DescRegex = $@"({OclockRegex})";
		public const string AmDescRegex = @"(am\b|a\.m\.|a m\b|a\. m\.|a\.m\b|a\. m\b|a m\b)";
		public const string PmDescRegex = @"(pm\b|p\.m\.|p\b|p m\b|p\. m\.|p\.m\b|p\. m\b|p m\b)";
		public const string AmPmDescRegex = @"(ampm)";
		public static readonly string TwoDigitYearRegex = $@"\b(?<![$])(?<year>([0-27-9]\d))(?!(\s*((\:)|{AmDescRegex}|{PmDescRegex}|\.\d)))\b";
		public const string FullTextYearRegex = @"^[\*]";
		public static readonly string YearRegex = $@"({BaseDateTime.FourDigitYearRegex}|{FullTextYearRegex})";
		public const string WeekDayRegex = @"(?<weekday>sonntag|montag|dienstag|mittwoch|donnerstag|freitag|samstag|(mo|di|mi|do|fr|sa|so)(\.))";
		public const string SingleWeekDayRegex = @"(?<weekday>sonntag|montag|dienstag|mittwoch|donnerstag|freitag|samstag|(mo|di|mi|do|fr|sa|so)(\.))";
		public static readonly string RelativeMonthRegex = $@"(?<relmonth>{RelativeRegex}\s+monat(s)?)";
		public const string WrittenMonthRegex = @"((monat\s*)?(?<month>april|apr\.|august|aug\.|dezember|dez\.|februar|feb\.|januar|jan\.|juli|jul\.|juni|jun\.|märz|mai|november|nov\.|oktober|okt\.|september|sep\.))";
		public static readonly string MonthSuffixRegex = $@"(?<msuf>(im\s*|des\s*)?({RelativeMonthRegex}|{WrittenMonthRegex}))";
		public const string DateUnitRegex = @"(?<unit>jahre|jahr|monate|monat|wochen|woche|tage|tag)(s)?";
		public static readonly string SimpleCasesRegex = $@"((vom|zwischen)\s+)?({DayRegex})(\s*{MonthSuffixRegex})?\s*{TillRegex}\s*({DayRegex})(\s*{MonthSuffixRegex})?((\s+|\s*,\s*){YearRegex})?";
		public static readonly string MonthFrontSimpleCasesRegex = $@"((vom|zwischen)\s*)?{MonthSuffixRegex}\s*((vom|zwischen)\s*)?({DayRegex})\s*{TillRegex}\s*({DayRegex})((\s+|\s*,\s*){YearRegex})?";
		public static readonly string MonthFrontBetweenRegex = $@"({MonthSuffixRegex}\s+(zwischen\s+)({DayRegex})\s*{RangeConnectorRegex}\s*({DayRegex})((\s+|\s*,\s*){YearRegex})?)";
		public static readonly string BetweenRegex = $@"((zwischen\s+)({DayRegex})(\s+{MonthSuffixRegex})?\s*{RangeConnectorRegex}\s*({DayRegex})(\s+{MonthSuffixRegex})((\s+|\s*,\s*){YearRegex})?|(zwischen\s+)({DayRegex})(\s+{MonthSuffixRegex})?\s*{RangeConnectorRegex}\s*({DayRegex})(\s+{MonthSuffixRegex})?((\s+|\s*,\s*){YearRegex})?)";
		public static readonly string MonthWithYear = $@"\b((?<month>april|apr\.|august|aug\.|dezember|dez\.|februar|feb\.|januar|jan\.|juli|jul\.|juni|jun\.|märz|mai|november|nov\.|oktober|okt\.|september|sep\.)(\s*),?(\s+des)?(\s*)({YearRegex}|(?<order>nächsten|letzten|diesen)\s+jahres))";
		public static readonly string OneWordPeriodRegex = $@"\b((((im\s+)?monat\s+)?({RelativeRegex}\s*(jahr\s*(im\s*)?)?)?(?<month>april|apr\.|august|aug\.|dezember|dez\.|februar|feb\.|januar|jan\.|juli|jul\.|juni|jun\.|märz|mai|november|nov\.|oktober|okt\.|september|sep\.))|({RelativeRegex}\s+)?(wochenende|woche|monat|jahr)|wochenende|(monat|jahr))\b";
		public static readonly string MonthNumWithYear = $@"({YearRegex}(\s*)[/\-\.](\s*){MonthNumRegex})|({MonthNumRegex}(\s*)[/\-](\s*){YearRegex})";
		public static readonly string WeekOfMonthRegex = $@"(?<wom>((die|der)\s+)(?<cardinal>erst(er|en|es|e)|1\.|zweit(er|en|es|e)|2\.|dritt(er|en|es|e)|3\.|viert(er|en|es|e)|4\.|fünft(er|en|es|e)|5\.|letzt(er|en|es|e))\s+woche\s+(des|diesen|im)\s+({MonthSuffixRegex}|monat(s)?))";
		public static readonly string WeekOfYearRegex = $@"(?<woy>((die|der)\s+)?(?<cardinal>(erst(er|en|es|e)|1\.|zweit(er|en|es|e)|2\.|dritt(er|en|es|e)|3\.|viert(er|en|es|e)|4\.|fünft(er|en|es|e)|5\.|letzt(er|en|es|e))\s+woche\s+(im|diesen|\s+des)?\s+({YearRegex}|{RelativeRegex}\s+jahr(en|es|e)?)))";
		public static readonly string FollowedDateUnit = $@"^\s*{DateUnitRegex}";
		public static readonly string NumberCombinedWithDateUnit = $@"\b(?<num>\d+(\.\d*)?){DateUnitRegex}";
		public static readonly string QuarterRegex = $@"((das|dem|im|in dem)\s+)?(?<cardinal>erst(en|es|e)|1st|zweit(en|es|e)|2nd|dritt(en|es|e)|3rd|viert(en|es|e)|4th)\s+quartal(\s+(von|des jahres)?|\s*,\s*)?\s+({YearRegex}|{RelativeRegex})";
		public static readonly string QuarterRegexYearFront = $@"(?!)#({YearRegex}|{RelativeRegex}\s+year)\s+(the\s+)?(?<cardinal>first|1st|second|2nd|third|3rd|fourth|4th)\s+quarter";
		public const string AllHalfYearRegex = @".^";
		public const string PrefixDayRegex = @".^";
		public const string CenturySuffixRegex = @".^";
		public static readonly string SeasonRegex = $@"\b(?<season>({RelativeRegex}\s+)?(?<seas>frühling|sommer|herbst|winter)((\s+(von|des jahres)?|\s*,\s*)?\s+({YearRegex}|{RelativeRegex}\s+jahr(e(s)?)?))?)\b";
		public const string WhichWeekRegex = @"(week)(\s*)(?<number>\d\d|\d|0\d)";
		public const string WeekOfRegex = @"(die\s+)?(woche)(\s+des)";
		public const string MonthOfRegex = @"(monat)(\s*)(des)";
		public const string MonthRegex = @"(?<month>april|apr.|august|aug.|dezember|dez.|februar|feb.|januar|jan.|juli|jul.|juni|jun.|märz|mai|november|nov.|oktober|okt.|september|sep.)";
		public static readonly string DateYearRegex = $@"(?<year>19\d{{2}}|20\d{{2}}|(([0-27-9]\d)(?!(\s*((\:)|{AmDescRegex}|{PmDescRegex})))))";
		public static readonly string OnRegex = $@"(?<=\bam\s+)({DayRegex}s?)\b";
		public const string RelaxedOnRegex = @"(?<=\b(am|an dem)\s+)((?<day>10|11|12|13|14|15|16|17|18|19|1|20|21|22|23|24|25|26|27|28|29|2|30|31|3|4|5|6|7|8|9)([\.]))";
		public static readonly string ThisRegex = $@"(((diese((n|m)|(\s*woche))(\s*am)?\s+){WeekDayRegex})|({WeekDayRegex})|diese(n|r)?\s*(sommer|winter|frühling|herbst))";
		public static readonly string LastDateRegex = $@"({{LastPrefixRegex}}(\s*(woche|monat|jahr)?(\s*(am|im))?)?\s+({WeekDayRegex}|sommer|winter|frühling|herbst))|((am\s+)?{WeekDayRegex}(\s+{{LastPrefixRegex}}\s*woche))";
		public static readonly string NextDateRegex = $@"({NextPrefixRegex}(\s*(woche|monat|jahr)?(\s*(am|im))?)?\s+({WeekDayRegex}|sommer|winter|frühling|herbst))|((am\s+)?{WeekDayRegex}(\s+{NextPrefixRegex}\s*woche))";
		public static readonly string SpecialDayRegex = $@"(vorgestern|übermorgen|((der\s+)?{RelativeRegex}\s+tag)|gestern|morgen|heute)";
		public const string SpecialDayWithNumRegex = @"^[.]";
		public static readonly string RelativeDayRegex = $@"((((der|dem|den|des)\s+)?{RelativeRegex}\s+tag(e(s)?)?))";
		public const string SetWeekDayRegex = @"\b(?<prefix>(am|an dem|in der)\s+)?(?<weekday>morgen|nachmittag|abend|nacht|sonntag|montag|dienstag|mittwoch|donnerstag|freitag|samstag)(s)?\b";
		public static readonly string WeekDayOfMonthRegex = $@"\b(?<wom>((dem|der|des|am|an dem)\s+)?(?<cardinal>erst(er|en|e)|1.|zweit(er|en|e)|2.|dritt(er|en|e)|3.|viert(er|en|e)|4.|fünft(er|en|e)|5.|letzt(er|en|e))\s+{WeekDayRegex}\s+{MonthSuffixRegex})\b";
		public const string RelativeWeekDayRegex = @"^[.]";
		public static readonly string SpecialDate = $@"(?=\b(an|am|an dem)\s+){DayRegex}\b";
		public static readonly string DateExtractor1 = $@"\b(({WeekDayRegex})(\s+|\s*,\s*))?({DayRegex})((\s*){MonthRegex})((\s+|\s*,\s*)({DateYearRegex}))?\b";
		public static readonly string DateExtractor2 = $@"\b({DayRegex}((\s*){MonthRegex})((\,\s*|\s*){DateYearRegex})?)\b";
		public static readonly string DateExtractor3 = $@"\b({DayRegex}{MonthRegex})";
		public static readonly string DateExtractor4 = $@"\b({DayRegex}\s*{MonthNumRegex}\s*{DateYearRegex})\b";
		public static readonly string DateExtractor5 = $@"\b({DayRegex}\s*[/\\\-\.]\s*({MonthNumRegex}|{MonthRegex})\s*[/\\\-\.]\s*{DateYearRegex})\b";
		public static readonly string DateExtractor6 = $@"\b(({WeekDayRegex}\s*)?(in)\s*(\d(\d)?)\s*(woche(n)?))\b";
		public static readonly string DateExtractor7 = $@"({DayRegex}\s*[\.]\s*{MonthNumRegex}[\.]\s*)";
		public static readonly string DateExtractor8 = $@"(?<=\b(am)\s+){DayRegex}[/\\\.]{MonthNumRegex}[/\\\.]({{DateYearRegex}})?\b";
		public static readonly string DateExtractor9 = $@"\b({DayRegex}\s*/\s*{MonthNumRegex}((\s+|\s*,\s*){DateYearRegex})?)\b";
		public static readonly string DateExtractor10 = $@"\b({RelativeRegex}\s*jahr(\s*im)?({MonthNumRegex}|sommer|winter|frühling|herbst)?)\b";
		public static readonly string DateExtractorA = $@"({DateYearRegex}\s*[/\\\-\.]\s*{MonthNumRegex}\s*[/\\\-\.]\s*{DayRegex})";
		public static readonly string OfMonth = $@"^(\s*des\s*|\s*)?{MonthRegex}";
		public static readonly string MonthEnd = $@"{MonthRegex}\s*(der|dem|den)?\s*$";
		public static readonly string WeekDayEnd = $@"{WeekDayRegex}\s*,?\s*$";
		public const string RangeUnitRegex = @"(?<unit>jahren|jahre|jahr|monaten|monate|monat|wochen|woche|tagen|tage|tag)";
		public const string OclockRegex = @"(?<oclock>uhr)";
		public const string HourNumRegex = @"\b(?<hournum>'null'|ein|eins|zwei|drei|vier|fünf|fuenf|sechs|sieben|acht|neun|zehn|elf|zwölf|zwoelf|dreizehn|vierzehn|fünfzehn|sechzehn|siebzehn|achtzehn|neunzehn|zwanzig|einundzwanzig|zweiundzwanzig|dreiundzwanzig|vierundzwanzig)\b";
		public const string MinuteNumRegex = @"(?<minnum>zwanzig|dreißig|vierzig|fünfzig|ein|eins|zwei|drei|vier|fünf|fuenf|sechs|sieben|acht|neun|zehn|elf|zwölf|zwoelf|dreizehn|vierzehn|fünfzehn|fuenfzehn|sechzehn|siebzehn|achtzehn|neunzehn)";
		public const string DeltaMinuteNumRegex = @"(?<deltaminnum>zwanzig|dreißig|vierzig|fünfzig|ein|eins|zwei|drei|vier|fünf|fuenf|sechs|sieben|acht|neun|zehn|elf|zwölf|zwoelf|dreizehn|vierzehn|fünfzehn|fuenfzehn|sechzehn|siebzehn|achtzehn|neunzehn)";
		public const string PmRegex = @"((((am|gegen|in der)\s+)?(?<pm>nachmittag(s)?|abend(s)?|mitternacht(s)?|mittag(s)?))|((in der)?\s*nacht(s)?))";
		public const string PmRegexFull = @"((((am|gegen|in der)\s+)?(?<pm>nachmittag(s)?|abend(s)?|mitternacht(s)?|mittag(s)?))|((in der)?\s*nacht(s)?))";
		public const string AmRegex = @"(?<am>((am|gegen)\s+)?(morgen(s)?|vormittag(s)?))";
		public const string LunchRegex = @"\b(mittag(s)?|mittagessen)\b";
		public const string NightRegex = @"\b(mitternacht|nacht(s)?)\b";
		public const string AmPmPrefixRegex = @"((((um|gegen)\s*)?(morgen(s)?|vormittag(s)?|mittag(s)?|nachmittag(s)?|abend(s)?|mitternacht(s)?)|(in der\s*)?nacht(s)?)\s*(um|gegen|von)\s*)";
		public const string CommonDatePrefixRegex = @"^[\.]";
		public static readonly string LessThanOneHour = $@"(?<lth>(eine(r)?\s+)?(viertel|dreiviertel|halb(en|e)?)(\s+Stunde(n)?)?)|{BaseDateTime.DeltaMinuteRegex}(\s+(minute|minuten|min))|{DeltaMinuteNumRegex}(\s+(minute|minuten|min))";
		public static readonly string WrittenTimeRegex = $@"(um\s*)?(?<writtentime>{HourNumRegex}(\s*{OclockRegex}\s*)({MinuteNumRegex}|{MinuteNumRegex}und(?<tens>zwanzig|dreißig|vierzig|fünfzig)))";
		public static readonly string TimePrefix = $@"(?<prefix>(um\s*)?({LessThanOneHour})(\s*(vor|nach))?)";
		public static readonly string TimeSuffix = $@"(?<suffix>{AmRegex}|{PmRegex}|{OclockRegex})";
		public static readonly string TimeSuffixFull = $@"(?<suffix>{AmRegex}|{{PmRegex}}|{OclockRegex}|(?<pm>nachmittag(s)?|nacht(s)?|abend(s)?))";
		public static readonly string BasicTime = $@"(?<basictime>{WrittenTimeRegex}|{HourNumRegex}|{BaseDateTime.HourRegex}:{BaseDateTime.MinuteRegex}(:{BaseDateTime.SecondRegex})?|{BaseDateTime.HourRegex})";
		public const string MidnightRegex = @"(?<midnight>mitternacht|mitten in der nacht)";
		public const string MidmorningRegex = @"(?<midmorning>vormittag|vormittags)";
		public const string MidafternoonRegex = @"^[\.]";
		public const string MiddayRegex = @"(?<midday>mittag|mittags)";
		public static readonly string MidTimeRegex = $@"(?<mid>({MidnightRegex}|{MidmorningRegex}|{MidafternoonRegex}|{MiddayRegex}))";
		public static readonly string AtRegex = $@"\b(((?<=\b(um|gegen)\s+)({WrittenTimeRegex}|{HourNumRegex}|{BaseDateTime.HourRegex}|{MidTimeRegex}))|{MidTimeRegex})\b";
		public static readonly string IshRegex = $@"\b({BaseDateTime.HourRegex}(-|——)?ish|noonish|noon)\b";
		public const string TimeUnitRegex = @"(?<unit>stunden|stunde|std|minuten|minute|min|sekunden|sekunde|sek|s)";
		public const string RestrictedTimeUnitRegex = @"(?<unit>stunde|minute)\b";
		public const string FivesRegex = @"(?<tens>(fünfzehn|(fünfund)?zwanzig?|(fünfund)?dreißig|(fünfund)?vierzig|(fünfund)?fünfzig|zehn|fünf))\b";
		public static readonly string HourRegex = $@"\b{BaseDateTime.HourRegex}";
		public const string PeriodHourNumRegex = @"(?<hour>einundzwanzig|zweiundzwanzig|dreiundzwanzig|vierundzwanzig|'null'|ein(s)?|zwei|drei|vier|fünf|sechs|sieben|acht|neun|zehn|elf|zwölf|dreizehn|vierzehn|fünfzehn|sechzehn|siebzehn|achtzehn|neunzehn|zwanzig)\b";
		public static readonly string ConnectNumRegex = $@"{BaseDateTime.HourRegex}(?<min>00|01|02|03|04|05|06|07|08|09|10|11|12|13|14|15|16|17|18|19|20|21|22|23|24|25|26|27|28|29|30|31|32|33|34|35|36|37|38|39|40|41|42|43|44|45|46|47|48|49|50|51|52|53|54|55|56|57|58|59)\s*{DescRegex}";
		public static readonly string TimeRegex1 = $@"({TimePrefix}\s+)?({WrittenTimeRegex}|{HourNumRegex}|{BaseDateTime.HourRegex})\s*{DescRegex}";
		public static readonly string TimeRegex2 = $@"({TimePrefix}\s+)?(t)?{BaseDateTime.HourRegex}(\s*)?:(\s*)?{BaseDateTime.MinuteRegex}((\s*)?:(\s*)?{BaseDateTime.SecondRegex})?((\s*{DescRegex})|\b)";
		public static readonly string TimeRegex3 = $@"({TimePrefix}\s+)?{BaseDateTime.HourRegex}\.{BaseDateTime.MinuteRegex}(\s*{DescRegex})";
		public static readonly string TimeRegex4 = $@"({TimePrefix}\s*{BasicTime}(\s*{DescRegex})?(\s*{TimeSuffix})?)";
		public static readonly string TimeRegex5 = $@"({TimePrefix}\s*{BasicTime}((\s*{DescRegex})))";
		public static readonly string TimeRegex6 = $@"({BasicTime}(\s*{DescRegex})?\s+{TimeSuffix})";
		public static readonly string TimeRegex7 = $@"(({AmPmPrefixRegex})?({BasicTime})((\s*{DescRegex}))?)";
		public static readonly string TimeRegex8 = $@"({TimeSuffixFull}(\s*(um|gegen)\s*){BasicTime}((\s*{DescRegex})?))";
		public static readonly string TimeRegex9 = $@"({PeriodHourNumRegex}\s+{FivesRegex}((\s*{DescRegex})))";
		public static readonly string TimeRegex10 = $@"({TimePrefix}\s+)?{BaseDateTime.HourRegex}(\s*h\s*){BaseDateTime.MinuteRegex}(\s*{DescRegex})?";
		public static readonly string PureNumFromTo = $@"((von|vom|zwischen)\s+)?({HourRegex}|{PeriodHourNumRegex})(\s*(?<leftDesc>{DescRegex}))?\s*{TillRegex}\s*({HourRegex}|{PeriodHourNumRegex})\s*(?<rightDesc>{PmRegex}|{AmRegex}|{DescRegex})?";
		public static readonly string PureNumBetweenAnd = $@"\b(zwischen\s+)({HourRegex}|{PeriodHourNumRegex})(\s*(?<leftDesc>{DescRegex}))?\s*{RangeConnectorRegex}\s*({HourRegex}|{PeriodHourNumRegex})\s*(?<rightDesc>{PmRegex}|{AmRegex}|{DescRegex})?\b";
		public const string SpecificTimeFromTo = @"^[.]";
		public const string SpecificTimeBetweenAnd = @"^[.]";
		public const string PrepositionRegex = @"(?<prep>^(um|am|vom|von|in)(\s+(der|dem|den))?$)";
		public const string TimeOfDayRegex = @"\b(?<timeOfDay>(((((?<early>(früh am|am frühen|früher)(\s+|-))|(?<late>(spät am|am späten|später)(\s+|-)))?(morgen(s)?|vormittag(s)?|mittag(s)?|nachmittag(s)?|abend(s)?|nacht(s)?)))))\b";
		public static readonly string SpecificTimeOfDayRegex = $@"\b(({StrictRelativeRegex}\s+{TimeOfDayRegex})\b|\bheute)s?\b";
		public static readonly string TimeFollowedUnit = $@"^\s*{TimeUnitRegex}$";
		public static readonly string TimeNumberCombinedWithUnit = $@"(?<num>\d+(\,\d*)?){TimeUnitRegex}";
		public const string NowRegex = @"\b(?<now>(genau\s+)?jetzt|so früh wie möglich|frühestmöglich|neulich|vorher)\b";
		public const string SuffixRegex = @"^\s*((am|in der)\s+)?(morgen|morgens|frühe|vormittag|vormittags|mittag|mittags|nachmittag|nachmittags|abend|abends|nacht|nachts)\b";
		public const string DateTimeTimeOfDayRegex = @"\b(?<timeOfDay>morgen(s)?|vormittag(s)?|mittag(s)?|nachmittag(s)?|nacht(s)?|abend(s)?)\b";
		public static readonly string DateTimeSpecificTimeOfDayRegex = $@"\b(({RelativeRegex}\s+{DateTimeTimeOfDayRegex})\b|\bheute)\b";
		public static readonly string TimeOfTodayAfterRegex = $@"^\s*(,\s*)?((am|in der)\s+)?{DateTimeSpecificTimeOfDayRegex}";
		public static readonly string TimeOfTodayBeforeRegex = $@"{DateTimeSpecificTimeOfDayRegex}(\s*,)?(\s+(um|gegen|in|on))?\s*$";
		public static readonly string SimpleTimeOfTodayAfterRegex = $@"({HourNumRegex}|{BaseDateTime.HourRegex})\s*(,\s*)?(am\s+)?{DateTimeSpecificTimeOfDayRegex}";
		public static readonly string SimpleTimeOfTodayBeforeRegex = $@"{DateTimeSpecificTimeOfDayRegex}(\s*,)?(\s+um)?\s*({HourNumRegex}|{BaseDateTime.HourRegex})";
		public const string SpecificEndOfRegex = @"((das|am|dem|an dem)\s+)?ende(\s+(dem|den|des|der)?)\s*";
		public const string UnspecificEndOfRegex = @"^[.]";
		public const string PeriodTimeOfDayRegex = @"\b(((?<early>(früh am|früher|am frühen)(\s+|-))|(?<late>(spät am|später|am späten)(\s+|-)))?(?<timeOfDay>morgen(s)?|vormittag(s)?|mittag(s)?|nachmittag(s)?|nacht(s)?|abend(s)?))\b";
		public static readonly string PeriodSpecificTimeOfDayRegex = $@"(({StrictRelativeRegex}\s+{PeriodTimeOfDayRegex})|heute)";
		public static readonly string PeriodTimeOfDayWithDateRegex = $@"\b((((am|von|in der)\s+)?{TimeOfDayRegex}(\s+am)?))\b";
		public const string LessThanRegex = @"^[.]";
		public const string MoreThanRegex = @"^[.]";
		public const string DurationUnitRegex = @"(?<unit>jahr(en|es|e)?|monat(en|e|s)?|woche(n)?|tag(en|es|e)?|stund(en|e)?|std|minute(n)?|min|sekunde(n)?|sek)\b";
		public const string SuffixAndRegex = @"(?<suffix>\s*(und)\s+((eine)\s+)?(?<suffix_num>halbe|viertel))";
		public const string PeriodicRegex = @"(?<periodic>(all)?täglich(er|en|es|e)?|(all)?monatlich(er|en|es|e)?|(all)?wöchentlich(er|en|es|e)?|(all)?jährlich(er|en|es|e)?)\b";
		public static readonly string EachUnitRegex = $@"(?<each>(jede(s|r|n|m)?|alle)(?<other>\s+andere(n)?)?\s*{DurationUnitRegex})";
		public const string EachPrefixRegex = @"\b(?<each>(jede(r|n|s)?|alle)\s*$)";
		public const string SetEachRegex = @"\b(?<each>(jede(r|n|s)?|alle)\s*)";
		public const string SetLastRegex = @"(?<last>nächste(r|n|s)?|kommende(r|n|s)?|diese(r|n|m|s)?|letzte(r|n|s)?|vorige(r|n|s)?|vorherige(r|n|s)?|jetzige(r|n|s)?|derzeitige(r|n|s)?)\b";
		public const string EachDayRegex = @"(\s*(jeden)\s*(Tag|tag)\s*)";
		public static readonly string DurationFollowedUnit = $@"\s*{SuffixAndRegex}?(\s+|-)?{DurationUnitRegex}";
		public static readonly string NumberCombinedWithDurationUnit = $@"\b(?<num>\d+(\.\d*)?)(-)?{DurationUnitRegex}";
		public static readonly string AnUnitRegex = $@"\b(((ein(er|es|en|em|e)?)(?<half>\s+halb(es|er|en|e))?))\s+{DurationUnitRegex}";
		public const string DuringRegex = @"^[.]";
		public const string AllRegex = @"\b(?<all>ganz(en|es|er|e)\s+(?<unit>jahr|monat|woche|tag))\b";
		public const string HalfRegex = @"(((ein(en|er|es|e)?)\s*)|\b)(?<half>halb(en|er|es|e)?\s+(?<unit>jahr(er|es|e)?|monat(s|e)?|woch(en|e)?|tag(en|er|es|e)?|stund(en|e)?))\b";
		public const string ConjunctionRegex = @"\b((und(\s+für)?)|mit|für)\b";
		public static readonly string HolidayRegex1 = $@"\b((dieses jahr)\s*)?(?<holiday>clean monday|good friday|ash wednesday|mardi gras|washington's birthday|mao's birthday|chinese new Year|neujahr|neujahrstag|vatertag|mayday|yuan dan|erster april|heiligabend|weihnachten|weihnachtstag|erntedankfest|halloween|yuandan|ostern|osterfest)(\s+((diesen)\s+)?({YearRegex}|{RelativeRegex}\s+jahres))?\b";
		public static readonly string HolidayRegex2 = $@"\b((dieses jahr)\s*)?(?<holiday>martin luther king|martin luther king jr|allerheiligen|tree planting day|white lover|st patrick|st george|cinco de mayo|independence|us independence|allerheiligen|allerseelen|guy fawkes|silvester)(\s+((diesen)\s+)?({YearRegex}|{RelativeRegex}\s+jahres))?\b";
		public static readonly string HolidayRegex3 = $@"((dieses jahr)\s*)?(?<holiday>(canberra|ostern|columbus|thanks\s*giving|weihnachten|weihnachtstag|tag der arbeit|muttertag|vatertag|female|single|teacher's|youth|children|arbor|girls|chsmilbuild|lover|labor|inauguration|groundhog|valentine's|baptiste|bastille|halloween|veterans|memorial|mid(-| )autumn|moon|spring|lantern|qingming|dragon boat|new years'|new year's|new year 's|new years|new year)\s+(day))(\s+((diesen)\s+)?({YearRegex}|{RelativeRegex}\s+jahres))?";
		public const string DateTokenPrefix = "am ";
		public const string TimeTokenPrefix = "um ";
		public const string TokenBeforeDate = "am ";
		public const string TokenBeforeTime = "um ";
		public const string AMTimeRegex = @"(?<am>morgen(s)?|vormittag(s)?)";
		public const string PMTimeRegex = @"(?<pm>nachmittag(s)?|abend(s)?|nacht(s)?)";
		public const string BeforeRegex = @"(vorher(ige(s|n|r)?)?|bevor|vor|vorige(s|n|r)?)";
		public const string AfterRegex = @"(nach)";
		public const string SinceRegex = @"\b(seit)\b";
		public const string AgoRegex = @"\b(ago)\b";
		public const string AroundRegex = @"^[.]";
		public const string LaterRegex = @"\b(später|von jetzt an)\b";
		public const string InConnectorRegex = @"\b(in)\b";
		public const string WithinNextPrefixRegex = @"^[.]";
		public const string MorningStartEndRegex = @"(^(morgen(s)?))|((morgen(s)?)$)";
		public const string AfternoonStartEndRegex = @"(^(nachmittag(s)?))|((nachmittag(s)?)$)";
		public const string EveningStartEndRegex = @"(^(abend(s)?))|((abend(s)?)$)";
		public const string NightStartEndRegex = @"(^(über nacht|heute nacht|nacht(s)?|nächtens|in der nacht))|((über nacht|heute nacht|nacht(s)?|nächtens)$)";
		public const string InexactNumberRegex = @"\b((ein )?paar|einige|wenige|einige wenige)\b";
		public static readonly string InexactNumberUnitRegex = $@"({InexactNumberRegex})\s+({DurationUnitRegex})";
		public static readonly string RelativeTimeUnitRegex = $@"((({NextPrefixRegex}|{PastPrefixRegex}|{ThisPrefixRegex})\s*({TimeUnitRegex})))";
		public static readonly string RelativeDurationUnitRegex = $@"(((?<=({NextPrefixRegex}|{PastPrefixRegex}|{ThisPrefixRegex})\s*)({DurationUnitRegex})))";
		public const string ReferenceDatePeriodRegex = @"^[.]";
		public const string ConnectorRegex = @"^(-|,|für|t|gegen)$";
		public const string FromToRegex = @"\b(vom|von).+(bis(\s*zum)?)\b.+";
		public const string SingleAmbiguousMonthRegex = @"^(the\s+)?(may|march)$";
		public const string UnspecificDatePeriodRegex = @"^[.]";
		public const string PrepositionSuffixRegex = @"\b(am|in|um|gegen|von|vom|zum)$";
		public const string FlexibleDayRegex = @"(?<DayOfMonth>([A-Za-z]+\s)?[A-Za-z\d]+)";
		public static readonly string ForTheRegex = $@"\b(für den {FlexibleDayRegex})";
		public static readonly string WeekDayAndDayOfMonthRegex = $@"\b{WeekDayRegex}\s+((der|den)\s+{FlexibleDayRegex})\b";
		public const string RestOfDateRegex = @"\brest\s+((der|des|dieser)\s+)((aktuellen|jetzigen)\s+)?(?<duration>woche|monats|jahres)\b";
		public const string RestOfDateTimeRegex = @"\brest\s+((des|diesen)\s+)((aktuellen|heutigen)\s+)?(?<unit>tages)\b";
		public const string MealTimeRegex = @"\b((zum|zur)\s+)?(?<mealTime>(essenszeit|mittagessen))\b";
		public static readonly string NumberEndingPattern = $@"^(\s+(?<meeting>meeting|appointment|conference|call|skype call)\s+to\s+(?<newTime>{PeriodHourNumRegex}|{HourRegex})((\.)?$|(\.,|,|!|\?)))";
		public const string OneOnOneRegex = @"\b(1\s*:\s*1)|(one (on )?one|one\s*-\s*one|one\s*:\s*one)\b";
		public static readonly string LaterEarlyPeriodRegex = $@"\b((?<LatePrefix>spät(er|en|e)?)|(?<EarlyPrefix>früh(er|en|e)))\s+(?<suffix>{OneWordPeriodRegex})\b";
		public static readonly string WeekWithWeekDayRangeRegex = $@"\b((?<week>({NextPrefixRegex}|{PastPrefixRegex}|diese(r|n|m))\s+woche)((\s+zwischen\s+{WeekDayRegex}\s+und\s+{WeekDayRegex})|(\s+vo(n|m)\s+{WeekDayRegex}\s+(bis\s+)?zum\s+{WeekDayRegex})))\b";
		public const string GeneralEndingRegex = @"\s*((\.,)|\.|,|!|\?)?\s*";
		public const string MiddlePauseRegex = @"\s*(,)\s*";
		public const string DurationConnectorRegex = @"^\s*(?<connector>\s+|und|für|,)\s*$";
		public const string PrefixArticleRegex = @"\b(der|dem|des)?\s+";
		public const string OrRegex = @"^[.]";
		public const string YearPlusNumberRegex = @"\b(Jahr\s+(?<number>(\d{3,4})))\b";
		public static readonly string NumberAsTimeRegex = $@"\b({WrittenTimeRegex}|{PeriodHourNumRegex}|{BaseDateTime.HourRegex})\b";
		public static readonly string TimeBeforeAfterRegex = $@"\b(((?<=\b(vor|nach)\s+)({WrittenTimeRegex}|{HourNumRegex}|{BaseDateTime.HourRegex}|{MidTimeRegex}))|{MidTimeRegex})\b";
		public const string DateNumberConnectorRegex = @"\s*(?<connector>am)\s*";
		public const string CenturyRegex = @"^[.]";
		public const string DecadeRegex = @"(?<decade>zwanziger|dreißiger|vierziger|fünfziger|sechziger|siebziger|achtziger|neunziger|zweitausender)(n)?";
		public static readonly string DecadeWithCenturyRegex = $@"(the\s+)?(((?<century>\d|1\d|2\d)?(')?(?<decade>\d0)(')?s)|(({CenturyRegex}(\s+|-)(and\s+)?)?{DecadeRegex})|({CenturyRegex}(\s+|-)(and\s+)?(?<decade>tens|hundreds)))";
		public const string RelativeDecadeRegex = @"^[.]";
		public static readonly string YearSuffix = $@"(,?\s*({DateYearRegex}|{FullTextYearRegex}))";
		public const string YearAfterRegex = @"^[.]";
		public const string YearPeriodRegex = @"(für|über)\s*(\d\s*)(Jahr(en|e)?)";
		public const string FutureSuffixRegex = @"^[.]";
		public const string ComplexDatePeriodRegex = @"^[.]";
		public static readonly Dictionary<string, string> UnitMap = new Dictionary<string, string>
		{
			{ "jahren", "Y" },
			{ "jahres", "Y" },
			{ "jahre", "Y" },
			{ "jahr", "Y" },
			{ "monaten", "MON" },
			{ "monate", "MON" },
			{ "monat", "MON" },
			{ "monats", "MON" },
			{ "wochen", "W" },
			{ "woche", "W" },
			{ "tagen", "D" },
			{ "tages", "D" },
			{ "tage", "D" },
			{ "tag", "D" },
			{ "stunden", "H" },
			{ "stunde", "H" },
			{ "h", "H" },
			{ "minuten", "M" },
			{ "minute", "M" },
			{ "min", "M" },
			{ "sekunden", "S" },
			{ "sekunde", "S" },
			{ "sek", "S" },
			{ "H", "H" }
		};
		public static readonly Dictionary<string, long> UnitValueMap = new Dictionary<string, long>
		{
			{ "jahren", 31536000 },
			{ "jahre", 31536000 },
			{ "jahr", 31536000 },
			{ "monaten", 2592000 },
			{ "monate", 2592000 },
			{ "monat", 2592000 },
			{ "wochen", 604800 },
			{ "woche", 604800 },
			{ "tagen", 86400 },
			{ "tage", 86400 },
			{ "tag", 86400 },
			{ "stunden", 3600 },
			{ "stunde", 3600 },
			{ "std", 3600 },
			{ "minuten", 60 },
			{ "minute", 60 },
			{ "min", 60 },
			{ "sekunden", 1 },
			{ "sekunde", 1 },
			{ "sek", 1 }
		};
		public static readonly Dictionary<string, string> SeasonMap = new Dictionary<string, string>
		{
			{ "spring", "SP" },
			{ "summer", "SU" },
			{ "fall", "FA" },
			{ "autumn", "FA" },
			{ "winter", "WI" }
		};
		public static readonly Dictionary<string, int> SeasonValueMap = new Dictionary<string, int>
		{
			{ "SP", 3 },
			{ "SU", 6 },
			{ "FA", 9 },
			{ "WI", 12 }
		};
		public static readonly Dictionary<string, int> CardinalMap = new Dictionary<string, int>
		{
			{ "erster", 1 },
			{ "ersten", 1 },
			{ "erstes", 1 },
			{ "erste", 1 },
			{ "1", 1 },
			{ "zweiter", 2 },
			{ "zweiten", 2 },
			{ "zweites", 2 },
			{ "zweite", 2 },
			{ "2", 2 },
			{ "dritter", 3 },
			{ "dritten", 3 },
			{ "drittes", 3 },
			{ "dritte", 3 },
			{ "3", 3 },
			{ "vierter", 4 },
			{ "vierten", 4 },
			{ "viertes", 4 },
			{ "vierte", 4 },
			{ "4", 4 },
			{ "fünfter", 5 },
			{ "fünften", 5 },
			{ "fünftes", 5 },
			{ "fünfte", 5 },
			{ "5", 5 }
		};
		public static readonly Dictionary<string, int> DayOfWeek = new Dictionary<string, int>
		{
			{ "montag", 1 },
			{ "dienstag", 2 },
			{ "mittwoch", 3 },
			{ "donnerstag", 4 },
			{ "freitag", 5 },
			{ "samstag", 6 },
			{ "sonntag", 0 },
			{ "mo.", 1 },
			{ "di.", 2 },
			{ "mi.", 3 },
			{ "do.", 4 },
			{ "fr.", 5 },
			{ "sa.", 6 },
			{ "so.", 0 }
		};
		public static readonly Dictionary<string, int> MonthOfYear = new Dictionary<string, int>
		{
			{ "januar", 1 },
			{ "februar", 2 },
			{ "märz", 3 },
			{ "april", 4 },
			{ "mai", 5 },
			{ "juni", 6 },
			{ "juli", 7 },
			{ "august", 8 },
			{ "september", 9 },
			{ "oktober", 10 },
			{ "november", 11 },
			{ "dezember", 12 },
			{ "jan", 1 },
			{ "feb", 2 },
			{ "mar", 3 },
			{ "apr", 4 },
			{ "jun", 6 },
			{ "jul", 7 },
			{ "aug", 8 },
			{ "sep", 9 },
			{ "okt", 10 },
			{ "nov", 11 },
			{ "dez", 12 },
			{ "1.", 1 },
			{ "2.", 2 },
			{ "3.", 3 },
			{ "4.", 4 },
			{ "5.", 5 },
			{ "6.", 6 },
			{ "7.", 7 },
			{ "8.", 8 },
			{ "9.", 9 },
			{ "10.", 10 },
			{ "11.", 11 },
			{ "12.", 12 },
			{ "01.", 1 },
			{ "02.", 2 },
			{ "03.", 3 },
			{ "04.", 4 },
			{ "05.", 5 },
			{ "06.", 6 },
			{ "07.", 7 },
			{ "08.", 8 },
			{ "09.", 9 },
			{ "1", 1 },
			{ "2", 2 },
			{ "3", 3 },
			{ "4", 4 },
			{ "5", 5 },
			{ "6", 6 },
			{ "7", 7 },
			{ "8", 8 },
			{ "9", 9 },
			{ "10", 10 },
			{ "11", 11 },
			{ "12", 12 },
			{ "01", 1 },
			{ "02", 2 },
			{ "03", 3 },
			{ "04", 4 },
			{ "05", 5 },
			{ "06", 6 },
			{ "07", 7 },
			{ "08", 8 },
			{ "09", 9 }
		};
		public static readonly Dictionary<string, int> Numbers = new Dictionary<string, int>
		{
			{ "null", 0 },
			{ "eins", 1 },
			{ "ein", 1 },
			{ "eine", 1 },
			{ "zwei", 2 },
			{ "drei", 3 },
			{ "vier", 4 },
			{ "fünf", 5 },
			{ "fuenf", 5 },
			{ "sechs", 6 },
			{ "sieben", 7 },
			{ "acht", 8 },
			{ "neun", 9 },
			{ "zehn", 10 },
			{ "elf", 11 },
			{ "zwölf", 12 },
			{ "dreizehn", 13 },
			{ "vierzehn", 14 },
			{ "fünfzehn", 15 },
			{ "sechzehn", 16 },
			{ "siebzehn", 17 },
			{ "achtzehn", 18 },
			{ "neunzehn", 19 },
			{ "zwanzig", 20 },
			{ "einundzwanzig", 21 },
			{ "zweiundzwanzig", 22 },
			{ "dreiundzwanzig", 23 },
			{ "vierundzwanzig", 24 },
			{ "fünfundzwanzig", 25 },
			{ "sechsundzwanzig", 26 },
			{ "siebenundzwanzig", 27 },
			{ "achtundzwanzig", 28 },
			{ "neunundzwanzig", 29 },
			{ "dreißig", 30 },
			{ "einunddreißig", 31 },
			{ "zweiunddreißig", 32 },
			{ "dreiunddreißig", 33 },
			{ "vierunddreißig", 34 },
			{ "fünfunddreißig", 35 },
			{ "sechsunddreißig", 36 },
			{ "siebenunddreißig", 37 },
			{ "achtunddreißig", 38 },
			{ "neununddreißig", 39 },
			{ "vierzig", 40 },
			{ "einundvierzig", 41 },
			{ "zweiundvierzig", 42 },
			{ "dreiundvierzig", 43 },
			{ "vierundvierzig", 44 },
			{ "fünfundvierzig", 45 },
			{ "sechsundvierzig", 46 },
			{ "siebenundvierzig", 47 },
			{ "achtundvierzig", 48 },
			{ "neunundvierzig", 49 },
			{ "fünfzig", 50 },
			{ "einundfünfzig", 51 },
			{ "zweiundfünfzig", 52 },
			{ "dreiundfünfzig", 53 },
			{ "vierundfünfzig", 54 },
			{ "fünfundfünfzig", 55 },
			{ "sechsundfünfzig", 56 },
			{ "siebenundfünfzig", 57 },
			{ "achtundfünfzig", 58 },
			{ "neunundfünfzig", 59 },
			{ "sechzig", 60 },
			{ "einundsechzig", 61 },
			{ "zweiundsechzig", 62 },
			{ "dreiundsechzig", 63 },
			{ "vierundsechzig", 64 },
			{ "fünfundsechzig", 65 },
			{ "sechsundsechzig", 66 },
			{ "siebenundsechzig", 67 },
			{ "achtundsechzig", 68 },
			{ "neunundsechzig", 69 },
			{ "siebzig", 70 },
			{ "einundsiebzig", 71 },
			{ "zweiundsiebzig", 72 },
			{ "dreiundsiebzig", 73 },
			{ "vierundsiebzig", 74 },
			{ "fünfundsiebzig", 75 },
			{ "sechsundsiebzig", 76 },
			{ "siebenundsiebzig", 77 },
			{ "achtundsiebzig", 78 },
			{ "neunundsiebzig", 79 },
			{ "achtzig", 80 },
			{ "einundachtzig", 81 },
			{ "zweiundachtzig", 82 },
			{ "dreiundachtzig", 83 },
			{ "vierundachtzig", 84 },
			{ "fünfundachtzig", 85 },
			{ "sechsundachtzig", 86 },
			{ "siebenundachtzig", 87 },
			{ "achtundachtzig", 88 },
			{ "neunundachtzig", 89 },
			{ "neunzig", 90 },
			{ "einundneunzig", 91 },
			{ "zweiundneunzig", 92 },
			{ "dreiundneunzig", 93 },
			{ "vierundneunzig", 94 },
			{ "fünfundneunzig", 95 },
			{ "sechsundneunzig", 96 },
			{ "siebenundneunzig", 97 },
			{ "achtundneunzig", 98 },
			{ "neunundneunzig", 99 },
			{ "einhundert", 100 }
		};
		public static readonly Dictionary<string, int> DayOfMonth = new Dictionary<string, int>
		{
			{ "1. ", 1 },
			{ "2. ", 2 },
			{ "3. ", 3 },
			{ "4. ", 4 },
			{ "5. ", 5 },
			{ "6. ", 6 },
			{ "7. ", 7 },
			{ "8. ", 8 },
			{ "9. ", 9 },
			{ "10. ", 10 },
			{ "11. ", 11 },
			{ "12. ", 12 },
			{ "13. ", 13 },
			{ "14. ", 14 },
			{ "15. ", 15 },
			{ "16. ", 16 },
			{ "17. ", 17 },
			{ "18. ", 18 },
			{ "19. ", 19 },
			{ "20. ", 20 },
			{ "21. ", 21 },
			{ "22. ", 22 },
			{ "23. ", 23 },
			{ "24. ", 24 },
			{ "25. ", 25 },
			{ "26. ", 26 },
			{ "27. ", 27 },
			{ "28. ", 28 },
			{ "29. ", 29 },
			{ "30. ", 30 },
			{ "31. ", 31 },
			{ "1", 1 },
			{ "2", 2 },
			{ "3", 3 },
			{ "4", 4 },
			{ "5", 5 },
			{ "6", 6 },
			{ "7", 7 },
			{ "8", 8 },
			{ "9", 9 },
			{ "10", 10 },
			{ "11", 11 },
			{ "12", 12 },
			{ "13", 13 },
			{ "14", 14 },
			{ "15", 15 },
			{ "16", 16 },
			{ "17", 17 },
			{ "18", 18 },
			{ "19", 19 },
			{ "20", 20 },
			{ "21", 21 },
			{ "22", 22 },
			{ "23", 23 },
			{ "24", 24 },
			{ "25", 25 },
			{ "26", 26 },
			{ "27", 27 },
			{ "28", 28 },
			{ "29", 29 },
			{ "30", 30 },
			{ "31", 31 }
		};
		public static readonly Dictionary<string, double> DoubleNumbers = new Dictionary<string, double>
		{
			{ "halb", 0.5 },
			{ "viertel", 0.25 }
		};
		public static readonly Dictionary<string, IEnumerable<string>> HolidayNames = new Dictionary<string, IEnumerable<string>>
		{
			{ "easterday", new string[] { "ostern" } },
			{ "fathers", new string[] { "vatertag" } },
			{ "mothers", new string[] { "muttertag" } },
			{ "thanksgiving", new string[] { "erntedankfest", "thanksgiving" } },
			{ "martinlutherking", new string[] { "martinlutherkingday", "martinlutherkingjrday" } },
			{ "washingtonsbirthday", new string[] { "washingtonsbirthday", "washingtonbirthday" } },
			{ "canberra", new string[] { "canberraday" } },
			{ "labour", new string[] { "tag der arbeit" } },
			{ "columbus", new string[] { "columbusday" } },
			{ "memorial", new string[] { "memorialday" } },
			{ "yuandan", new string[] { "yuandan" } },
			{ "maosbirthday", new string[] { "maosbirthday" } },
			{ "teachersday", new string[] { "teachersday", "teacherday" } },
			{ "singleday", new string[] { "singleday" } },
			{ "allsaintsday", new string[] { "allerheiligen" } },
			{ "youthday", new string[] { "tag der jugend" } },
			{ "childrenday", new string[] { "kindertag" } },
			{ "femaleday", new string[] { "frauentag" } },
			{ "treeplantingday", new string[] { "treeplantingday" } },
			{ "arborday", new string[] { "tag des baumes" } },
			{ "girlsday", new string[] { "girlsday" } },
			{ "whiteloverday", new string[] { "whiteloverday" } },
			{ "loverday", new string[] { "loverday" } },
			{ "christmas", new string[] { "weihnachten", "weihnachtstag" } },
			{ "xmas", new string[] { "xmas" } },
			{ "newyear", new string[] { "neujahr" } },
			{ "newyearday", new string[] { "neujahrstag" } },
			{ "newyearsday", new string[] { "neujahrstag" } },
			{ "inaugurationday", new string[] { "inaugurationday" } },
			{ "groundhougday", new string[] { "Murmeltiertag" } },
			{ "valentinesday", new string[] { "valentinstag" } },
			{ "stpatrickday", new string[] { "stpatrickday" } },
			{ "aprilfools", new string[] { "erster april", "aprilscherz" } },
			{ "stgeorgeday", new string[] { "georgstag" } },
			{ "mayday", new string[] { "mayday" } },
			{ "cincodemayoday", new string[] { "cinco de mayo" } },
			{ "baptisteday", new string[] { "geburt johannes des täufers" } },
			{ "usindependenceday", new string[] { "us unabhängigkeitstag" } },
			{ "independenceday", new string[] { "unabhängigkeitstag" } },
			{ "bastilleday", new string[] { "sturm auf die bastille" } },
			{ "halloweenday", new string[] { "halloween" } },
			{ "allhallowday", new string[] { "allerheiligen" } },
			{ "allsoulsday", new string[] { "allerseelen" } },
			{ "guyfawkesday", new string[] { "guy fawkes day", "guy fawkes night" } },
			{ "veteransday", new string[] { "veterans day" } },
			{ "christmaseve", new string[] { "heiligabend" } },
			{ "newyeareve", new string[] { "silvester" } }
		};
		public static readonly Dictionary<string, int> WrittenDecades = new Dictionary<string, int>
		{
			{ "hundert", 0 },
			{ "zehn", 10 },
			{ "zwanziger", 20 },
			{ "dreißiger", 30 },
			{ "vierziger", 40 },
			{ "fünfziger", 50 },
			{ "sechziger", 60 },
			{ "siebziger", 70 },
			{ "achtziger", 80 },
			{ "neunziger", 90 },
			{ "zwanzigern", 20 },
			{ "dreißigern", 30 },
			{ "vierzigern", 40 },
			{ "fünfzigern", 50 },
			{ "sechzigern", 60 },
			{ "siebzigern", 70 },
			{ "achtzigern", 80 },
			{ "neunzigern", 90 }
		};
		public static readonly Dictionary<string, int> SpecialDecadeCases = new Dictionary<string, int>
		{
			{ "zweitausender", 2000 }
		};
		public const string DefaultLanguageFallback = "DMY";
		public static readonly string[] DurationDateRestrictions = {  };
		public static readonly IList<string> MorningTermList = new List<string>
		{
			"morgen"
		};
		public static readonly IList<string> AfternoonTermList = new List<string>
		{
			"nachmittag"
		};
		public static readonly IList<string> EveningTermList = new List<string>
		{
			"abend"
		};
		public static readonly IList<string> DaytimeTermList = new List<string>
		{
			"tag"
		};
		public static readonly IList<string> NightTermList = new List<string>
		{
			"nacht"
		};
		public static readonly IList<string> SameDayTerms = new List<string>
		{
			"heute"
		};
		public static readonly IList<string> PlusOneDayTerms = new List<string>
		{
			"morgen",
			"tmr"
		};
		public static readonly IList<string> MinusOneDayTerms = new List<string>
		{
			"gestern"
		};
		public static readonly IList<string> PlusTwoDayTerms = new List<string>
		{
			"übermorgen"
		};
		public static readonly IList<string> MinusTwoDayTerms = new List<string>
		{
			"vorgestern"
		};
	}
}