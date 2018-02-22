
// ReSharper disable IdentifierTypo
namespace Microsoft.SharePoint.Client.Search.Query
{
    public class QueryMock : Query
    {


        public override System.Int32 BlockDedupeMode => BlockDedupeModeEx;
        public System.Int32 BlockDedupeModeEx { get; set; }

        public override System.Boolean BypassResultTypes => BypassResultTypesEx;
        public System.Boolean BypassResultTypesEx { get; set; }

        public override System.String ClientType => ClientTypeEx;
        public System.String ClientTypeEx { get; set; }

        public override System.Int32 Culture => CultureEx;
        public System.Int32 CultureEx { get; set; }

        public override System.Int32 DesiredSnippetLength => DesiredSnippetLengthEx;
        public System.Int32 DesiredSnippetLengthEx { get; set; }

        public override System.Boolean EnableInterleaving => EnableInterleavingEx;
        public System.Boolean EnableInterleavingEx { get; set; }

        public override System.Boolean EnableNicknames => EnableNicknamesEx;
        public System.Boolean EnableNicknamesEx { get; set; }

        public override System.Boolean EnableOrderingHitHighlightedProperty => EnableOrderingHitHighlightedPropertyEx;
        public System.Boolean EnableOrderingHitHighlightedPropertyEx { get; set; }

        public override System.Boolean EnablePhonetic => EnablePhoneticEx;
        public System.Boolean EnablePhoneticEx { get; set; }

        public override System.Boolean EnableQueryRules => EnableQueryRulesEx;
        public System.Boolean EnableQueryRulesEx { get; set; }

        public override System.Boolean EnableStemming => EnableStemmingEx;
        public System.Boolean EnableStemmingEx { get; set; }

        public override System.Boolean GenerateBlockRankLog => GenerateBlockRankLogEx;
        public System.Boolean GenerateBlockRankLogEx { get; set; }

        public override System.Int32 HitHighlightedMultivaluePropertyLimit => HitHighlightedMultivaluePropertyLimitEx;
        public System.Int32 HitHighlightedMultivaluePropertyLimitEx { get; set; }

        public override Microsoft.SharePoint.Client.Search.Query.StringCollection HitHighlightedProperties => HitHighlightedPropertiesEx;
        public Microsoft.SharePoint.Client.Search.Query.StringCollection HitHighlightedPropertiesEx { get; set; }

        public override System.Boolean IgnoreSafeQueryPropertiesTemplateUrl => IgnoreSafeQueryPropertiesTemplateUrlEx;
        public System.Boolean IgnoreSafeQueryPropertiesTemplateUrlEx { get; set; }

        public override System.String ImpressionID => ImpressionIDEx;
        public System.String ImpressionIDEx { get; set; }

        public override System.Int32 MaxSnippetLength => MaxSnippetLengthEx;
        public System.Int32 MaxSnippetLengthEx { get; set; }

        public override Microsoft.SharePoint.Client.Search.Query.QueryPersonalizationData PersonalizationData => PersonalizationDataEx;
        public Microsoft.SharePoint.Client.Search.Query.QueryPersonalizationData PersonalizationDataEx { get; set; }

        public override System.Boolean ProcessBestBets => ProcessBestBetsEx;
        public System.Boolean ProcessBestBetsEx { get; set; }

        public override System.Boolean ProcessPersonalFavorites => ProcessPersonalFavoritesEx;
        public System.Boolean ProcessPersonalFavoritesEx { get; set; }

        public override System.String QueryTag => QueryTagEx;
        public System.String QueryTagEx { get; set; }

        public override System.String QueryTemplate => QueryTemplateEx;
        public System.String QueryTemplateEx { get; set; }

        public override System.Collections.Generic.IDictionary<System.String,System.Boolean> QueryTemplateParameters => QueryTemplateParametersEx;
        public System.Collections.Generic.IDictionary<System.String,System.Boolean> QueryTemplateParametersEx { get; set; }

        public override System.String QueryText => QueryTextEx;
        public System.String QueryTextEx { get; set; }

        public override System.String RankingModelId => RankingModelIdEx;
        public System.String RankingModelIdEx { get; set; }

        public override System.String ResultsUrl => ResultsUrlEx;
        public System.String ResultsUrlEx { get; set; }

        public override System.Int32 RowLimit => RowLimitEx;
        public System.Int32 RowLimitEx { get; set; }

        public override System.Int32 RowsPerPage => RowsPerPageEx;
        public System.Int32 RowsPerPageEx { get; set; }

        public override System.String SafeQueryPropertiesTemplateUrl => SafeQueryPropertiesTemplateUrlEx;
        public System.String SafeQueryPropertiesTemplateUrlEx { get; set; }

        public override System.Boolean ShowPeopleNameSuggestions => ShowPeopleNameSuggestionsEx;
        public System.Boolean ShowPeopleNameSuggestionsEx { get; set; }

        public override System.Guid SourceId => SourceIdEx;
        public System.Guid SourceIdEx { get; set; }

        public override System.Int32 StartRow => StartRowEx;
        public System.Int32 StartRowEx { get; set; }

        public override System.Int32 SummaryLength => SummaryLengthEx;
        public System.Int32 SummaryLengthEx { get; set; }

        public override System.Int32 Timeout => TimeoutEx;
        public System.Int32 TimeoutEx { get; set; }

        public override System.Int32 TotalRowsExactMinimum => TotalRowsExactMinimumEx;
        public System.Int32 TotalRowsExactMinimumEx { get; set; }

        public override System.Boolean TrimDuplicates => TrimDuplicatesEx;
        public System.Boolean TrimDuplicatesEx { get; set; }

        public override System.Int32 UILanguage => UILanguageEx;
        public System.Int32 UILanguageEx { get; set; }

        public override Microsoft.SharePoint.Client.ClientResult<Microsoft.SharePoint.Client.Search.Query.QuerySuggestionResults> GetQuerySuggestionsWithResults(System.Int32 @iNumberOfQuerySuggestions, System.Int32 @iNumberOfResultSuggestions, System.Boolean @fPreQuerySuggestions, System.Boolean @fHitHighlighting, System.Boolean @fCapitalizeFirstLetters, System.Boolean @fPrefixMatchAllTerms)
        {
            return GetQuerySuggestionsWithResultsEx;
        }
        public Microsoft.SharePoint.Client.ClientResult<Microsoft.SharePoint.Client.Search.Query.QuerySuggestionResults> GetQuerySuggestionsWithResultsEx { get; set;}

    }
}

