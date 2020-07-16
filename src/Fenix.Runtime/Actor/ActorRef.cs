using System;
using System.Collections.Generic;
using System.Text;

namespace Fenix
{
    public partial class ActorRef
    {
        public Actor fromActor;

        public uint toActorId;

        public static ActorRef Create(uint toActorId, Actor fromActor)
        {
            var obj = new ActorRef();
            obj.toActorId = toActorId;
            obj.fromActor = fromActor;
            return obj;
        } 

        public void CallActorMethod(uint protocolCode, object msg, bool hasCallback)
        {
            fromActor.Rpc(protocolCode, this.toActorId, msg, hasCallback);
        }
    }
}