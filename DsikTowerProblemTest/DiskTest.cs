using DiskTowersProblem;
using FluentAssertions;

namespace DsikTowerProblemTest
{
    [TestClass]
    public class DiskTest
    {
        [TestMethod]
        public void Build_Test_Tower_Sequence_Descending_Order()
        {
            //Arranage
            DiskTowerBulder c = new DiskTowerBulder();
            c.numberOfDisks = 6;
            c.diskSizes = new List<int> { 6, 5, 4, 3, 2, 1 };



            //ACT
            string Expected = string.Join(" ", c.diskSizes);
            List<string> diskTower=c.buildTower();



            // Assert

            diskTower.Should().HaveCount(1);

        }
        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void Build_Test_Tower_Sequence_Contains_0()
        {
            //Arranage
            DiskTowerBulder c = new DiskTowerBulder();
            c.numberOfDisks = 6;
            c.diskSizes = new List<int> { 6, 5, 0, 3, 2, 1 };



            //ACT
            
            List<string> diskTower = c.buildTower();



            // Assert

                

        }
    }
}