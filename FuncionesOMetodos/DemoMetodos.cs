using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuncionesOMetodos
{
    class DemoMetodos
    {
        public void StopService()
        {

        }

        /// <summary>
        /// Este metodo lo que hace es procesar la info y ya
        /// </summary>
        /// <param name="serviceId"></param>
        public void StopService(int serviceId)
        {

        }


        /// <summary>
        /// Este metodo procesa la info de acuerdo a el parametro entrante  
        /// </summary>
        /// <param name="serviceName"></param>
        public void StopService(string serviceName)
        {

        }

        public int StopServiceConParametrosOpcionales(bool forceStop, string serviceName = null, int serviceId = 1)
        {
            if (serviceName == null)
                return 0;
            else
                return serviceName.Length;
            return -1;
        }

        public void EnviarValor(int upTime)
        {
            upTime = 3;
        }

        public void EnviarValorPorReferencia(ref int upTime)
        {
            upTime = 3;
        }

        public bool IsServiceOnLine(string serviceName, out string statusMessage) {
            var isOnline = true;
            if (serviceName == null)
            {
                isOnline = false;
                statusMessage = "No me envio datos";
            }
            else {
                if (serviceName == "salesService")
                {
                    statusMessage = "services is currently running.";
                }
                else {
                    statusMessage = "services is currently stopped.";
                }
            }
            return isOnline;
        }
    }
}
