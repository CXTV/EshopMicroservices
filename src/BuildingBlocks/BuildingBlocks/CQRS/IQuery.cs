using MediatR;

namespace BuildingBlocks.CQRS
{
    //有返回值的查询
    public interface IQuery<out TResponse>:IRequest<TResponse> where TResponse : notnull
    {

    }
}
