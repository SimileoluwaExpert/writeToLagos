using Microsoft.Azure.WebJobs;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace writeToLagos
{
    public class Functions
    {
        // This function will get triggered/executed when a new message is written 
        // on an Azure Queue called queue.
        public static void ProcessQueueMessage([QueueTrigger("queue")] writetostorage message, [Blob("outputdata/logmydata.txt", FileAccess.Write)] TextWriter bidWriter, TextWriter log)
        {
            bidWriter.WriteLine("Message Id {queue.ID} with message {queue.LogText}");
            log.WriteLine(message);
        }
    }
}
