using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace PCAxis.Menu.UnitTest
{
    [TestClass]
    public class TableLinkTest
    {
        [TestMethod]
        public void IdShouldBeCombinationOfMenuAndSelection()
        {
            //Arrange

            //Act
            TableLink lnk = new TableLink("Table text", "Table short text", "Sortcode", "MENU", "SELECTION", "Table description", LinkType.Table, TableStatus.AccessibleToAll, DateTime.Now, DateTime.Now, "2000", "2019", "Table id", PresCategory.Official);

            //Assert
            Assert.AreEqual(lnk.ID.Menu, "MENU");
            Assert.AreEqual(lnk.ID.Selection, "SELECTION");
        }
    }
}
