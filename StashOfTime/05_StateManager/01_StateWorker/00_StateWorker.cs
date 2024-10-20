
using ST_StateManager.Object;

namespace ST_StateManager.Worker
{
    public class ST_StateWorker
    {
        Dictionary<Guid, ST_StateObject> G_StateObjects = new Dictionary<Guid, ST_StateObject>();

        public ST_StateWorker()
        {

        }

        public ST_StateObject _Create()
        {
            ST_StateObject L_ST_StateObject = new ST_StateObject();
            _Store(L_ST_StateObject);
            return L_ST_StateObject;
        }

        public ST_StateObject _Get(Guid P_Id)
        {
            return G_StateObjects[P_Id];
        }

        public Guid _Store(ST_StateObject P_SHD_Object)
        {
            //if (P_SHD_Object._Get_StateId() == Guid.Empty)
            //{
            //    P_SHD_Object._Set_StateId(Guid.NewGuid());
            //}

            G_StateObjects.Add(P_SHD_Object.StateId, P_SHD_Object);

            return P_SHD_Object.StateId;
        }

        public void _Remove(Guid P_Id)
        {
            G_StateObjects.Remove(P_Id);
        }

        public bool _HasState(Guid P_StateId)
        {
            return G_StateObjects.ContainsKey(P_StateId);
        }
    }
}
