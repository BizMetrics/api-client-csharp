using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;

namespace Swagger.Client.Model {
  public class PeriodType {
    public string name { get; set; }

    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class PeriodType {\n");
      sb.Append("  name: ").Append(name).Append("\n");
      sb.Append("}\n");
      return sb.ToString();
    }
  }
  }
