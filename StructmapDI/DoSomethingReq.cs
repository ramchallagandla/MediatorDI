using MediatorDI;

namespace StructmapDI
{
    public class DoSomethingReq : IRequest<bool>
    {
       public bool Input { get; set; }
    }
}