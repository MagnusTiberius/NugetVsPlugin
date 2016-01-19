using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.Shell.Interop;
using Microsoft.VisualStudio.Shell;

namespace EidPassportInc.VSPackage1
{
    public class SolutionEvent : IVsSolutionEvents
    {
        private ServiceProvider serviceProvider;
        private IVsSolution solution;
        private uint solutionEventsCookie;
        private EnvDTE.DTE dte;

        public SolutionEvent(ServiceProvider sp)
        {
            serviceProvider = sp;
            solution = (IVsSolution)Microsoft.VisualStudio.Shell.Package.GetGlobalService(typeof(IVsSolution));
            dte = (EnvDTE.DTE)Microsoft.VisualStudio.Shell.Package.GetGlobalService(typeof(EnvDTE.DTE));
            //serviceProvider.GetService(typeof(SVsSolution)) as IVsSolution;
            if (solution != null)
            {
                solution.AdviseSolutionEvents(this, out solutionEventsCookie);
            }
        }

        public int OnAfterCloseSolution(object pUnkReserved)
        {
            //throw new NotImplementedException();
            return 0;
        }

        public int OnAfterLoadProject(IVsHierarchy pStubHierarchy, IVsHierarchy pRealHierarchy)
        {
            //throw new NotImplementedException();
            return 0;
        }

        public int OnAfterOpenProject(IVsHierarchy pHierarchy, int fAdded)
        {
            //throw new NotImplementedException();
            return 0;
        }

        public int OnAfterOpenSolution(object pUnkReserved, int fNewSolution)
        {
            //throw new NotImplementedException();
            foreach (EnvDTE.Project dteProject in dte.Solution)
            {
                var n = dteProject.Name;
            }
            return 0;
        }

        public int OnBeforeCloseProject(IVsHierarchy pHierarchy, int fRemoved)
        {
            //throw new NotImplementedException();
            return 0;
        }

        public int OnBeforeCloseSolution(object pUnkReserved)
        {
            //throw new NotImplementedException();
            return 0;
        }

        public int OnBeforeUnloadProject(IVsHierarchy pRealHierarchy, IVsHierarchy pStubHierarchy)
        {
            //throw new NotImplementedException();
            return 0;
        }

        public int OnQueryCloseProject(IVsHierarchy pHierarchy, int fRemoving, ref int pfCancel)
        {
            //throw new NotImplementedException();
            return 0;
        }

        public int OnQueryCloseSolution(object pUnkReserved, ref int pfCancel)
        {
            //throw new NotImplementedException();
            return 0;
        }

        public int OnQueryUnloadProject(IVsHierarchy pRealHierarchy, ref int pfCancel)
        {
            //throw new NotImplementedException();
            return 0;
        }
    }
}
