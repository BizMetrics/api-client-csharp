using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;

namespace Swagger.Client.Model {
  public class List {
    public bool? empty { get; set; }

    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class List {\n");
      sb.Append("  empty: ").Append(empty).Append("\n");
      sb.Append("}\n");
      return sb.ToString();
    }
  }
  }
