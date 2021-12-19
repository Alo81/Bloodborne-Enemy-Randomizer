using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace MSB_Test
{
    public partial class MainWindow
    {
        public void BuildMapLists()
        {
            coreMapList.Add(filePath + "\\map\\mapstudio\\" + "m21_00_00_00.msb.dcx");
            coreMapList.Add(filePath + "\\map\\mapstudio\\" + "m21_01_00_00.msb.dcx");
            coreMapList.Add(filePath + "\\map\\mapstudio\\" + "m22_00_00_00.msb.dcx");
            coreMapList.Add(filePath + "\\map\\mapstudio\\" + "m23_00_00_00.msb.dcx");
            coreMapList.Add(filePath + "\\map\\mapstudio\\" + "m23_00_00_01.msb.dcx");
            coreMapList.Add(filePath + "\\map\\mapstudio\\" + "m24_00_00_00.msb.dcx");
            coreMapList.Add(filePath + "\\map\\mapstudio\\" + "m24_00_00_01.msb.dcx");
            coreMapList.Add(filePath + "\\map\\mapstudio\\" + "m24_01_00_00.msb.dcx");
            coreMapList.Add(filePath + "\\map\\mapstudio\\" + "m24_01_00_01.msb.dcx");
            coreMapList.Add(filePath + "\\map\\mapstudio\\" + "m24_01_00_11.msb.dcx");
            coreMapList.Add(filePath + "\\map\\mapstudio\\" + "m24_02_00_00.msb.dcx");
            coreMapList.Add(filePath + "\\map\\mapstudio\\" + "m24_02_00_01.msb.dcx");
            coreMapList.Add(filePath + "\\map\\mapstudio\\" + "m25_00_00_00.msb.dcx");
            coreMapList.Add(filePath + "\\map\\mapstudio\\" + "m26_00_00_00.msb.dcx");
            coreMapList.Add(filePath + "\\map\\mapstudio\\" + "m27_00_00_00.msb.dcx");
            coreMapList.Add(filePath + "\\map\\mapstudio\\" + "m27_00_00_01.msb.dcx");
            coreMapList.Add(filePath + "\\map\\mapstudio\\" + "m28_00_00_00.msb.dcx");
            coreMapList.Add(filePath + "\\map\\mapstudio\\" + "m28_00_00_01.msb.dcx");
            coreMapList.Add(filePath + "\\map\\mapstudio\\" + "m32_00_00_00.msb.dcx");
            coreMapList.Add(filePath + "\\map\\mapstudio\\" + "m32_00_00_01.msb.dcx");
            coreMapList.Add(filePath + "\\map\\mapstudio\\" + "m33_00_00_00.msb.dcx");
            coreMapList.Add(filePath + "\\map\\mapstudio\\" + "m34_00_00_00.msb.dcx");
            coreMapList.Add(filePath + "\\map\\mapstudio\\" + "m35_00_00_00.msb.dcx");
            coreMapList.Add(filePath + "\\map\\mapstudio\\" + "m36_00_00_00.msb.dcx");
            chaliceMapList.Add(filePath + "\\map\\mapstudio\\" + "m29_10_90_00\\m29_10_90_00.msb.dcx");
            chaliceMapList.Add(filePath + "\\map\\mapstudio\\" + "m29_10_90_00\\m29_10_90_01.msb.dcx");
            chaliceMapList.Add(filePath + "\\map\\mapstudio\\" + "m29_20_90_00\\m29_20_90_00.msb.dcx");
            chaliceMapList.Add(filePath + "\\map\\mapstudio\\" + "m29_20_90_00\\m29_20_90_01.msb.dcx");
            chaliceMapList.Add(filePath + "\\map\\mapstudio\\" + "m29_21_90_00\\m29_21_90_00.msb.dcx");
            chaliceMapList.Add(filePath + "\\map\\mapstudio\\" + "m29_30_90_00\\m29_30_90_00.msb.dcx");
            chaliceMapList.Add(filePath + "\\map\\mapstudio\\" + "m29_30_90_00\\m29_30_90_01.msb.dcx");
            chaliceMapList.Add(filePath + "\\map\\mapstudio\\" + "m29_31_90_00\\m29_31_90_00.msb.dcx");
            chaliceMapList.Add(filePath + "\\map\\mapstudio\\" + "m29_40_90_00\\m29_40_90_00.msb.dcx");
            chaliceMapList.Add(filePath + "\\map\\mapstudio\\" + "m29_40_90_00\\m29_40_90_01.msb.dcx");
            chaliceMapList.Add(filePath + "\\map\\mapstudio\\" + "m29_42_90_00\\m29_42_90_00.msb.dcx");
            chaliceMapList.Add(filePath + "\\map\\mapstudio\\" + "m29_42_90_00\\m29_42_90_01.msb.dcx");
            chaliceMapList.Add(filePath + "\\map\\mapstudio\\" + "m29_50_90_00\\m29_50_90_00.msb.dcx");
            chaliceMapList.Add(filePath + "\\map\\mapstudio\\" + "m29_50_90_00\\m29_50_90_01.msb.dcx");
            chaliceMapList.Add(filePath + "\\map\\mapstudio\\" + "m29_52_90_00\\m29_52_90_00.msb.dcx");
            chaliceMapList.Add(filePath + "\\map\\mapstudio\\" + "m29_52_90_00\\m29_52_90_01.msb.dcx");
            chaliceMapList.Add(filePath + "\\map\\mapstudio\\" + "m29_53_90_00\\m29_53_90_00.msb.dcx");
            chaliceMapList.Add(filePath + "\\map\\mapstudio\\" + "m29_53_90_00\\m29_53_90_01.msb.dcx");

            if (File.Exists(filePath + "\\map\\mapstudio\\" + "m29_50_40_00\\m29_50_40_00.msb.dcx"))
            {
                chaliceMapList.Add(filePath + "\\map\\mapstudio\\" + "m29_50_40_00\\m29_50_40_00.msb.dcx");
                GOBAdded = true;
            }
        }

        public void BuildEventList()
        {
            eventFileList.Add(filePath + "\\event\\m21_00_00_00.emevd.dcx");
            eventFileList.Add(filePath + "\\event\\m21_01_00_00.emevd.dcx");
            eventFileList.Add(filePath + "\\event\\m22_00_00_00.emevd.dcx");
            eventFileList.Add(filePath + "\\event\\m23_00_00_00.emevd.dcx");
            eventFileList.Add(filePath + "\\event\\m24_00_00_00.emevd.dcx");
            eventFileList.Add(filePath + "\\event\\m24_01_00_00.emevd.dcx");
            eventFileList.Add(filePath + "\\event\\m24_02_00_00.emevd.dcx");
            eventFileList.Add(filePath + "\\event\\m25_00_00_00.emevd.dcx");
            eventFileList.Add(filePath + "\\event\\m26_00_00_00.emevd.dcx");
            eventFileList.Add(filePath + "\\event\\m27_00_00_00.emevd.dcx");
            eventFileList.Add(filePath + "\\event\\m28_00_00_00.emevd.dcx");
            eventFileList.Add(filePath + "\\event\\m32_00_00_00.emevd.dcx");
            eventFileList.Add(filePath + "\\event\\m33_00_00_00.emevd.dcx");
            eventFileList.Add(filePath + "\\event\\m34_00_00_00.emevd.dcx");
            eventFileList.Add(filePath + "\\event\\m35_00_00_00.emevd.dcx");
            eventFileList.Add(filePath + "\\event\\m36_00_00_00.emevd.dcx");
        }
    }
}
