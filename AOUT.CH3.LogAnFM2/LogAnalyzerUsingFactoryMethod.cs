using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AOUT.CH3.LogAnFM2
{
    public interface IExtensionManager
    {
        bool IsValid(string fileName);
    }

    public class FileExtensionManager : IExtensionManager
    {
        public bool IsValid(string fileName)
        {
            return true;
            // здесь читается файл                   
        }
    }

    public class LogAnalyzerUsingFactoryMethod
    {
        public bool IsValidLogFileName(string fileName)
        {
            return this.IsValid(fileName);
        }

        protected virtual bool IsValid(string fileName)
        {
            FileExtensionManager mgr = new FileExtensionManager();
            return mgr.IsValid(fileName);
        }
    }
}
