namespace MediatorDI
{
    public interface IMediator
    {
        TResponse Process<TResponse>(IRequest<TResponse> req);
    }
}
