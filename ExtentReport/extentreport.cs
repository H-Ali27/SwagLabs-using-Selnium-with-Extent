using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Swaglabs_Framework
{
    public class extentreport : baseclass
    {
        public static ExtentHtmlReporter htmlReporter = new ExtentHtmlReporter(path);
        public static ExtentReports report = new ExtentReports();
        public static ExtentTest parent;
        public static ExtentTest childreport;

        public static void LogReport(string detail, string filename, string path)
        {
            //parent = report.CreateTest("TestReport");
            //childreport = parent.CreateNode("Login");
            baseclass.screenshot(filename, path,"PNG");
            childreport.Log(Status.Pass, (detail + " :Pass"),MediaEntityBuilder.CreateScreenCaptureFromPath(path + filename).Build());
        }
        public static void Parent_Log(string parentTag)
        {
            parent = report.CreateTest(parentTag);
        }
        public static void ChildLog(String Nodename)
        {
            childreport = parent.CreateNode(Nodename);
        }
        public static void LogReportFailed(string detail, string filename, string path)
        {
            baseclass.screenshot(filename, path, "PNG");
            childreport.Log(Status.Pass, (detail + " :Pass"), MediaEntityBuilder.CreateScreenCaptureFromPath(path + filename).Build());
        }

        public static void Report()
        {
            report.AttachReporter(htmlReporter);
        }
        public static void flush()
        {
            report.Flush();
        }
}
    }
