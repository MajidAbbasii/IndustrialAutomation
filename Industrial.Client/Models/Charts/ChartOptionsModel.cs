using System.Text.Json.Serialization;
using Industrial.Client.Models.Charts.Annotations;
using Industrial.Client.Models.Charts.Chart;
using Industrial.Client.Models.Charts.DataLabels;
using Industrial.Client.Models.Charts.Fill;
using Industrial.Client.Models.Charts.ForecastDataPoints;
using Industrial.Client.Models.Charts.Grid;
using Industrial.Client.Models.Charts.Legend;
using Industrial.Client.Models.Charts.NoData;
using Industrial.Client.Models.Charts.PlotOptions;
using Industrial.Client.Models.Charts.Responsive;
using Industrial.Client.Models.Charts.Series;
using Industrial.Client.Models.Charts.States;
using Industrial.Client.Models.Charts.Stroke;
using Industrial.Client.Models.Charts.Subtitle;
using Industrial.Client.Models.Charts.Theme;
using Industrial.Client.Models.Charts.Title;
using Industrial.Client.Models.Charts.Tooltip;
using Industrial.Client.Models.Charts.XAxis;
using Industrial.Client.Models.Charts.YAxis;

namespace Industrial.Client.Models.Charts;

public class ChartOptionsModel<TSeries, TXAxis>
{
    [JsonPropertyName("annotations")] public AnnotationsModel Annotations { get; set; } = new();
    [JsonPropertyName("chart")] public ChartModel Chart { get; set; } = new();
    //
    [JsonPropertyName("colors")]
    public List<string> Colors { get; set; } = new() {"var(--mud-palette-primary)", "var(--mud-palette-secondary)"};
    
    [JsonPropertyName("dataLabels")] public DataLabelsModel DataLabels { get; set; } = new();
    [JsonPropertyName("fill")] public FillModel Fill { get; set; } = new();
    
    [JsonPropertyName("forecastDataPoints")]
    public ForecastDataPointsModel ForecastDataPoints { get; set; } = new();

    // [JsonPropertyName("grid")] public GridModel Grid { get; set; } = new(); // TODO: Yaxis issue...
    [JsonPropertyName("labels")] public List<string> Labels { get; set; } = new();
    [JsonPropertyName("legend")] public LegendModel Legend { get; set; } = new();
    [JsonPropertyName("markers")] public LegendModel.MarkersModel Markers { get; set; } = new();
    [JsonPropertyName("noData")] public NoDataModel NoData { get; set; } = new();
    [JsonPropertyName("plotOptions")] public PlotOptionsModel PlotOptions { get; set; } = new();
    [JsonPropertyName("responsive")] public List<ResponsiveModel> Responsive { get; set; } = new();
    [JsonPropertyName("series")] public List<TSeries> Series { get; set; } = new();
    [JsonPropertyName("states")] public StatesModel States { get; set; } = new();
    [JsonPropertyName("stroke")] public StrokeModel Stroke { get; set; } = new();
    [JsonPropertyName("subtitle")] public SubtitleModel Subtitle { get; set; } = new();
    [JsonPropertyName("theme")] public ThemeModel Theme { get; set; } = new();
    [JsonPropertyName("title")] public TitleModel Title { get; set; } = new();
    [JsonPropertyName("tooltip")] public TooltipModel Tooltip { get; set; } = new();
    [JsonPropertyName("xaxis")] public XAxisModel<TXAxis> XAxis { get; set; } = new();
    [JsonPropertyName("yaxis")] public YAxisModel YAxis { get; set; } = new();
}