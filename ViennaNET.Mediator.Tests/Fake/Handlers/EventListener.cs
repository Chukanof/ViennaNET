﻿using System.Threading;
using System.Threading.Tasks;
using NUnit.Framework;

namespace ViennaNET.Mediator.Tests.Fake.Handlers
{
  public class EventListener : IMessageHandler<Event>
  {
    public void Handle(Event message)
    {
      TestContext.WriteLine($"The {nameof(EventListener)} listened {message.GetType().FullName}");
    }
  }
}
