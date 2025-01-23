using MediatR;

namespace BuildingBlocks.CQRS
{
    //无返回值的写入
    public interface ICommand : ICommand<Unit>
    {
    }
    //有返回值的写入
    public interface ICommand<out TResponse> : IRequest<TResponse>
    {
    }
}
