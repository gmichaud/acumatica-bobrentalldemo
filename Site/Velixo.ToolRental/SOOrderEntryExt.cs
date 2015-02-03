using System;
using System.Collections;
using PX.Data;
using PX.Objects.SO;
using PX.Objects.IN;
    
namespace Velixo.ToolRental
{
    public class SOOrderEntryExt : PXGraphExtension<SOOrderEntry>
    {
        public PXAction<SOOrder> createRental;
        [PXUIField(DisplayName = "Create Rental")]
        [PXProcessButton]
        public IEnumerable CreateRental(PXAdapter adapter)
        {
            // Find matching tool
            var tool = (Tool) PXSelectJoin<Tool, InnerJoin<InventoryItem, On<Tool.toolCD, Equal<InventoryItem.inventoryCD>>>, Where<InventoryItem.inventoryID, Equal<Current<SOLine.inventoryID>>>>.Select(Base);
            if(tool == null)
            {
                throw new PXException("No tool was found matching code of currently selected inventory item.");
            }

            // Initialize tool management graph and position it on the currently selected tool
            var toolManagement = PXGraph.CreateInstance<ToolManagement>();
            toolManagement.Tools.Current = tool;

            // Add a row to rental grid
            var rental = (Rental) toolManagement.Rentals.Cache.CreateInstance();
            rental.CustomerID = Base.Document.Current.CustomerID;
            rental.StartDate = Base.Document.Current.OrderDate;
            toolManagement.Rentals.Insert(rental);

            // Redirect to tool management page
            throw new PXRedirectRequiredException(toolManagement, true, "Rental");
        }

    }
}
