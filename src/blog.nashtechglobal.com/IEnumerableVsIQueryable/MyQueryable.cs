using System.Collections;
using System.Linq.Expressions;

namespace IEnumerableVsIQueryable;

internal class MyQueryable<TElement> : IQueryable<TElement>
{
    private readonly MyQueryProvider _provider = new();

    public Type ElementType => typeof(TElement);

    public Expression Expression { get; }

    public IQueryProvider Provider => _provider;

    public MyQueryable()
    {
        Expression = Expression.Constant(this);
    }

    public MyQueryable(Expression expression)
    {
        Expression = expression;
    }

    public IEnumerator<TElement> GetEnumerator()
    {
        return _provider.Execute<IEnumerator<TElement>>(Expression);
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}


internal class MyQueryProvider : IQueryProvider
{
    public IQueryable CreateQuery(Expression expression)
    {
        throw new NotImplementedException();
    }

    public IQueryable<TElement> CreateQuery<TElement>(Expression expression)
    {
        return new MyQueryable<TElement>(expression);
    }

    public object Execute(Expression expression)
    {
        throw new NotImplementedException();
    }

    public TResult Execute<TResult>(Expression expression)
    {
        ExpressionVisitor vistor = new MyExpressionVisitor();
        vistor.Visit(expression);

        return (TResult)Execute(expression);
    }
}

class MyExpressionVisitor : ExpressionVisitor
{

    private string? _sql = null;

    public override Expression? Visit(Expression? node)
    {
        return base.Visit(node);
    }

    protected override Expression VisitMethodCall(MethodCallExpression node)
    {
        if (node.Method.Name == "Select")
        {
            _sql += "SELECT ";

            // TODO: Get Columns
        }
        else if (node.Method.Name == "Where")
        {
            _sql += "WHERE ";

            // TODO: Get Columns
        }

        return base.VisitMethodCall(node);
    }
}
