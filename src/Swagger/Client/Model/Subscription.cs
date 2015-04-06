using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;

namespace Swagger.Client.Model {
  public class Subscription {
    public DateTime? extActivationDate { get; set; }

    public DateTime? extEndDate { get; set; }

    public string name { get; set; }

    public Period subsInterval { get; set; }

    public int? amount { get; set; }

    public DateTime? canceledAt { get; set; }

    public Status status { get; set; }

    public string clientId { get; set; }

    public string planId { get; set; }

    public Map<string,string> classifiers { get; set; }

    public ExternalId externalId { get; set; }

    public DateTime? extCreationInstant { get; set; }

    public DateTime? extLastModifiedInstant { get; set; }

    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class Subscription {\n");
      sb.Append("  extActivationDate: ").Append(extActivationDate).Append("\n");
      sb.Append("  extEndDate: ").Append(extEndDate).Append("\n");
      sb.Append("  name: ").Append(name).Append("\n");
      sb.Append("  subsInterval: ").Append(subsInterval).Append("\n");
      sb.Append("  amount: ").Append(amount).Append("\n");
      sb.Append("  canceledAt: ").Append(canceledAt).Append("\n");
      sb.Append("  status: ").Append(status).Append("\n");
      sb.Append("  clientId: ").Append(clientId).Append("\n");
      sb.Append("  planId: ").Append(planId).Append("\n");
      sb.Append("  classifiers: ").Append(classifiers).Append("\n");
      sb.Append("  externalId: ").Append(externalId).Append("\n");
      sb.Append("  extCreationInstant: ").Append(extCreationInstant).Append("\n");
      sb.Append("  extLastModifiedInstant: ").Append(extLastModifiedInstant).Append("\n");
      sb.Append("}\n");
      return sb.ToString();
    }
  }
  }
