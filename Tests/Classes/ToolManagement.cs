using Core;

namespace Velixo.ToolRental.Tests
{
    public class ToolManagement : VX301000_ToolManagement
    {
        public c_tools_form Summary
        {
            get
            {
                return base.Tools_form;
            }
        }

        public c_rentals_grid Details
        {
            get
            {
                return base.Rentals_grid;
            }
        }
    }
}
