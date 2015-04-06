using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;

namespace Swagger.Client.Model {
  public class RefundBean {
    public ExternalId extId { get; set; }

    public int? amount { get; set; }

    public DateTime? dateOfChange { get; set; }

    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class RefundBean {\n");
      sb.Append("  extId: ").Append(extId).Append("\n");
      sb.Append("  amount: ").Append(amount).Append("\n");
      sb.Append("  dateOfChange: ").Append(dateOfChange).Append("\n");
      sb.Append("}\n");
      return sb.ToString();
    }
  }
  }
