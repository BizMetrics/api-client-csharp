using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;

namespace Swagger.Client.Model {
  public class Period {
    public int? hours { get; set; }

    public int? minutes { get; set; }

    public int? seconds { get; set; }

    public int? millis { get; set; }

    public int? months { get; set; }

    public int? years { get; set; }

    public int? days { get; set; }

    public int? weeks { get; set; }

    public PeriodType periodType { get; set; }

    public List<int?> values { get; set; }

    public List<DurationFieldType> fieldTypes { get; set; }

    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class Period {\n");
      sb.Append("  hours: ").Append(hours).Append("\n");
      sb.Append("  minutes: ").Append(minutes).Append("\n");
      sb.Append("  seconds: ").Append(seconds).Append("\n");
      sb.Append("  millis: ").Append(millis).Append("\n");
      sb.Append("  months: ").Append(months).Append("\n");
      sb.Append("  years: ").Append(years).Append("\n");
      sb.Append("  days: ").Append(days).Append("\n");
      sb.Append("  weeks: ").Append(weeks).Append("\n");
      sb.Append("  periodType: ").Append(periodType).Append("\n");
      sb.Append("  values: ").Append(values).Append("\n");
      sb.Append("  fieldTypes: ").Append(fieldTypes).Append("\n");
      sb.Append("}\n");
      return sb.ToString();
    }
  }
  }
