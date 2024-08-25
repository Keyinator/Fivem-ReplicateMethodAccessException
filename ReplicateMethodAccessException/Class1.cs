using CitizenFX.Core;
using CitizenFX.FiveM.Native;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Collections.Specialized.BitVector32;

namespace ReplicateMethodAccessException
{
    public class Class1 : BaseScript
    {
        [Command("test")]
        public void Test() {
            Natives.SendNuiMessage(JsonConvert.SerializeObject(new {
                action="test",
                data=""
            }));
        }

        [NuiCallback("nuiCallback")]
        private void NuiCallback(IDictionary<string, object> data, Callback cb) {
            cb(new {
                okay = true
            });
        }
    }
}
