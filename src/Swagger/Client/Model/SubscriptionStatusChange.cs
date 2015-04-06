using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;

namespace Swagger.Client.Model {
  public class SubscriptionStatusChange {
    public Status newStatus { get; set; }

    public DateTime? dateOfChange { get; set; }

    public bool? force { get; set; }

    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class SubscriptionStatusChange {\n");
      sb.Append("  newStatus: ").Append(newStatus).Append("\n");
      sb.Append("  dateOfChange: ").Append(dateOfChange).Append("\n");
      sb.Append("  force: ").Append(force).Append("\n");
      sb.Append("}\n");
      return sb.ToString();
    }
  }
  }
