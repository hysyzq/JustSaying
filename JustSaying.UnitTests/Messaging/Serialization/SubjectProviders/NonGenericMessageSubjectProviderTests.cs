using System.Collections.Generic;
using JustSaying.Messaging.MessageSerialization;
using Shouldly;
using Xunit;

namespace JustSaying.UnitTests.Messaging.Serialization.SubjectProviders
{
    public class NonGenericMessageSubjectProviderTests
    {
        class Foo { }

        [Fact]
        public void GetSubjectForType_ReturnsTypeName() =>
            new NonGenericMessageSubjectProvider().GetSubjectForType(typeof(Foo))
                .ShouldBe("Foo");

        [Fact]
        public void GetSubjectForType_IgnoresAnyTypeParameters() =>
            new NonGenericMessageSubjectProvider().GetSubjectForType(typeof(List<Foo>))
                .ShouldBe("List`1");
    }
}
