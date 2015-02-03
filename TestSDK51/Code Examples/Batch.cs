using Core;

namespace TestAcumatica.Extension
{
    public class Batch : GL301000_JournalEntry
    {
        public c_batchmodule_form Summary
        {
            get
            {
                return base.BatchModule_form;
            }
            set
            {
                base.BatchModule_form = value;
            }
        }

        public c_gltranmodulebatnbr_grid Details
        {
            get
            {
                return base.GLTranModuleBatNbr_grid;
            }
            set
            {
                base.GLTranModuleBatNbr_grid = value;
            }
        }
    }
}