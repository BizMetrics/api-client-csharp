using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;

namespace Swagger.Client.Model {
  public class RefundEvent {
    public int? originalAmount { get; set; }

    public ExternalId subsId { get; set; }

    public int? amount { get; set; }

    public Object id { get; set; }

    public ExternalId externalId { get; set; }

    public Client client { get; set; }

    public Subscription subscription { get; set; }

    public DateTime? extCreationInstant { get; set; }

    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class RefundEvent {\n");
      sb.Append("  originalAmount: ").Append(originalAmount).Append("\n");
      sb.Append("  subsId: ").Append(subsId).Append("\n");
      sb.Append("  amount: ").Append(amount).Append("\n");
      sb.Append("  id: ").Append(id).Append("\n");
      sb.Append("  externalId: ").Append(externalId).Append("\n");
      sb.Append("  client: ").Append(client).Append("\n");
      sb.Append("  subscription: ").Append(subscription).Append("\n");
      sb.Append("  extCreationInstant: ").Append(extCreationInstant).Append("\n");
      sb.Append("}\n");
      return sb.ToString();
    }
  }
  }
