//---------------------------------------------------------------------
// <copyright file="AggregateExpressionToken.cs" company="Microsoft">
//      Copyright (C) Microsoft Corporation. All rights reserved. See License.txt in the project root for license information.
// </copyright>
//---------------------------------------------------------------------

#if ASTORIA_CLIENT
namespace Microsoft.OData.Client.ALinq.UriParser
{
    using Microsoft.OData.Core.UriParser.Aggregation;
#else
namespace Microsoft.OData.Core.UriParser.Aggregation
{
#endif
    using Microsoft.OData.Core.UriParser.TreeNodeKinds;
    using Microsoft.OData.Core.UriParser.Visitors;
    using Microsoft.OData.Core.UriParser.Syntactic;

    /// <summary>
    /// Query token representing an Aggregate expression.
    /// </summary>
    public sealed class AggregateExpressionToken : QueryToken
    {
        private readonly QueryToken expression;

        private readonly AggregationMethod method;

        private readonly string alias;

        /// <summary>
        /// Create an AggregateExpressionToken.
        /// </summary>
        /// <param name="expression">The aggregate expression.</param>
        /// <param name="withVerb">The aggregation method.</param>
        /// <param name="alias">The alias for this query token.</param>
        public AggregateExpressionToken(QueryToken expression, AggregationMethod withVerb, string alias)
        {
            ExceptionUtils.CheckArgumentNotNull(expression, "expression");
            ExceptionUtils.CheckArgumentNotNull(alias, "alias");

            this.expression = expression;
            this.method = withVerb;
            this.alias = alias;
        }

        /// <summary>
        /// Gets the kind of this token.
        /// </summary>
        public override QueryTokenKind Kind
        {
            get { return QueryTokenKind.AggregateExpression; }
        }

        /// <summary>
        /// Gets the AggregationMethod of this token.
        /// </summary>
        public AggregationMethod Method
        {
            get { return this.method; }
        }

        /// <summary>
        /// Gets the expression.
        /// </summary>
        public QueryToken Expression
        {
            get { return this.expression; }
        }

        /// <summary>
        /// Gets the alias.
        /// </summary>
        public string Alias
        {
            get { return this.alias; }
        }
       
        /// <summary>
        /// Accept a <see cref="ISyntacticTreeVisitor{T}"/> to walk a tree of <see cref="QueryToken"/>s.
        /// </summary>
        /// <typeparam name="T">Type that the visitor will return after visiting this token.</typeparam>
        /// <param name="visitor">An implementation of the visitor interface.</param>
        /// <returns>An object whose type is determined by the type parameter of the visitor.</returns>
        public override T Accept<T>(ISyntacticTreeVisitor<T> visitor)
        {
            return visitor.Visit(this);
        }
    }
}
