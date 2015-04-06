using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;

namespace Swagger.Client.Model {
  public class Plan {
    public int? amount { get; set; }

    public string currency { get; set; }

    public string metaDescription { get; set; }

    public Period planInterval { get; set; }

    public PlanState state { get; set; }

    public string name { get; set; }

    public Map<string,string> classifiers { get; set; }

    public ExternalId externalId { get; set; }

    public DateTime? extCreationInstant { get; set; }

    public DateTime? extLastModifiedInstant { get; set; }

    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class Plan {\n");
      sb.Append("  amount: ").Append(amount).Append("\n");
      sb.Append("  currency: ").Append(currency).Append("\n");
      sb.Append("  metaDescription: ").Append(metaDescription).Append("\n");
      sb.Append("  planInterval: ").Append(planInterval).Append("\n");
      sb.Append("  state: ").Append(state).Append("\n");
      sb.Append("  name: ").Append(name).Append("\n");
      sb.Append("  classifiers: ").Append(classifiers).Append("\n");
      sb.Append("  externalId: ").Append(externalId).Append("\n");
      sb.Append("  extCreationInstant: ").Append(extCreationInstant).Append("\n");
      sb.Append("  extLastModifiedInstant: ").Append(extLastModifiedInstant).Append("\n");
      sb.Append("}\n");
      return sb.ToString();
    }
  }
  }
