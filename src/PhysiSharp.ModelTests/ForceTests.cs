using PhysiSharp.Models;
using Xunit;

namespace PhysiSharp.ModelTests
{
   public class ForceTests
   {

      [Fact]
      void TestAdditionOp()
      {
         var test = new Force();
         test.Magnitude = 1;
         Assert.Equal(1, test.Magnitude);
         Assert.NotNull(test);
      }
   }
}
