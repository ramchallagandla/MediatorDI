using MediatorDI;

namespace StructmapDI
{
    public class DoSomethingHandler : BaseRequestHandler<DoSomethingReq, bool>
    {
        public override bool Handle(DoSomethingReq request)
        {
            return request.Input;
        }
    }
}
