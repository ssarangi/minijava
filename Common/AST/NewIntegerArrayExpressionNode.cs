﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MiniJava.AST
{
    public class NewIntegerArrayExpressionNode : ExpressionNode
    {
        public ExpressionNode expression;

        public NewIntegerArrayExpressionNode(ExpressionNode expressionNode, int lineNumber)
        {
            this.expression = expressionNode;
            this.lineNumber = lineNumber;
        }

        public override string toString()
        {
            return "";
        }

        public override void Accept(MiniJava.Visitors.IVisitor visitor)
        {
            visitor.Visit(this);
        }

    }
}
