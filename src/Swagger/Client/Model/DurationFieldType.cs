using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;

namespace Swagger.Client.Model {
  public class DurationFieldType {
    public string name { get; set; }

    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class DurationFieldType {\n");
      sb.Append("  name: ").Append(name).Append("\n");
      sb.Append("}\n");
      return sb.ToString();
    }
  }
  }
