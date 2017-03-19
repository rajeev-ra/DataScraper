using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataScraper
{
    class Worker
    {
        private bool _bLiveMint = false;
        private bool _bFE = false;
        private bool _bHindu = false;
        private string _selection = "";
        
        public object[,] _lvd = null;

        private System.ComponentModel.BackgroundWorker _bgWorker = new System.ComponentModel.BackgroundWorker();

        public Worker(bool bLiveMint, bool bFE, bool bHindu, string selection)
        {
            _bLiveMint = bLiveMint;
            _bFE = bFE;
            _bHindu = bHindu;
            _selection = selection;

            _bgWorker.DoWork += _bgWorker_DoWork;
            _bgWorker.RunWorkerCompleted += _bgWorker_RunWorkerCompleted;
            _bgWorker.RunWorkerAsync();
        }

        public object[,] GetLiveMintData()
        {
            return _lvd;
        }

        private void _bgWorker_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            MainForm.DoExcel();
        }

        private void _bgWorker_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            if(_bLiveMint)
            {
                LiveMintData lvd = new LiveMintData();
                _lvd = lvd.Execute(_selection);
            }
        }
    }
}
