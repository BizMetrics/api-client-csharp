using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;

namespace Swagger.Client.Model {
  public class Client {
    public string name { get; set; }

    public string email { get; set; }

    public string description { get; set; }

    public Map<string,string> classifiers { get; set; }

    public ExternalId externalId { get; set; }

    public DateTime? extCreationInstant { get; set; }

    public DateTime? extLastModifiedInstant { get; set; }

    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class Client {\n");
      sb.Append("  name: ").Append(name).Append("\n");
      sb.Append("  email: ").Append(email).Append("\n");
      sb.Append("  description: ").Append(description).Append("\n");
      sb.Append("  classifiers: ").Append(classifiers).Append("\n");
      sb.Append("  externalId: ").Append(externalId).Append("\n");
      sb.Append("  extCreationInstant: ").Append(extCreationInstant).Append("\n");
      sb.Append("  extLastModifiedInstant: ").Append(extLastModifiedInstant).Append("\n");
      sb.Append("}\n");
      return sb.ToString();
    }
  }
  }
