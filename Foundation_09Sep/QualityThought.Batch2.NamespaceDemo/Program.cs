using QualityThought.Batch2.NamespaceLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QualityThought.Batch2.NamespaceLibrary.UI;
using MyUI = QualityThought.Batch2.NamespaceLibrary.UI;
using QualityThought.Batch2.NamespaceLibrary.Common;
using MyCommon = QualityThought.Batch2.NamespaceLibrary.Common;

namespace QualityThought.Batch2.NamespaceDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Test test = new Test();
            QualityThought.Batch2.NamespaceLibrary.UI.TestUI testui = new NamespaceLibrary.UI.TestUI();
            TestUI ui = new TestUI();
            QualityThought.Batch2.NamespaceLibrary.Common.TestCommon testCommon = new NamespaceLibrary.Common.TestCommon();
            TestCommon testC = new TestCommon();
            MyCommon.TestMe testMe = new MyCommon.TestMe();
            MyUI.TestMe testMeUI = new MyUI.TestMe();
        }
    }
}
