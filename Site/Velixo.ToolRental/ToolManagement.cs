using System;
using System.Collections;
using PX.Data;

namespace Velixo.ToolRental
{
    public class ToolManagement : PXGraph<ToolManagement, Tool>
    {
        public PXSelect<Tool> Tools;
        public PXSelect<Rental, Where<Rental.toolCD, Equal<Current<Tool.toolCD>>>> Rentals;
    }
}
