using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;

namespace Swagger.Client.Model {
  public class ExternalId {
    public string externalId { get; set; }

    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ExternalId {\n");
      sb.Append("  externalId: ").Append(externalId).Append("\n");
      sb.Append("}\n");
      return sb.ToString();
    }
  }
  }
