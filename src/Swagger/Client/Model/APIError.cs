using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;

namespace Swagger.Client.Model {
  public class APIError {
    public string reason { get; set; }

    public Throwable cause { get; set; }

    public string message { get; set; }

    public string localizedMessage { get; set; }

    public List<StackTraceElement> stackTrace { get; set; }

    public List<Throwable> suppressed { get; set; }

    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class APIError {\n");
      sb.Append("  reason: ").Append(reason).Append("\n");
      sb.Append("  cause: ").Append(cause).Append("\n");
      sb.Append("  message: ").Append(message).Append("\n");
      sb.Append("  localizedMessage: ").Append(localizedMessage).Append("\n");
      sb.Append("  stackTrace: ").Append(stackTrace).Append("\n");
      sb.Append("  suppressed: ").Append(suppressed).Append("\n");
      sb.Append("}\n");
      return sb.ToString();
    }
  }
  }
