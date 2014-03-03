﻿using MiniJava.Visitors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MiniJava.Backend.Visitors
{
    class LivenessVisitor : BaseVisitor
    {
        public LivenessVisitor(ProgramAnalysis analysis)
            : base(analysis)
        {

        }

        #region Visitor Members
        public override void Visit(AST.ProgramNode node)
        {
            base.Visit(node);
        }


        #region Declarations
        public override void Visit(AST.MainClassDeclNode node)
        {
            base.Visit(node);
        }

        public override void Visit(AST.MethodDeclNode node)
        {
            base.Visit(node);
        }
        #endregion

        #region Expression
        public override void Visit(AST.IntegerConstantExpressionNode node)
        {
            base.Visit(node);
        }

        public override void Visit(AST.BooleanConstantExpressionNode node)
        {
            base.Visit(node);
        }

        public override void Visit(AST.AddExpressionNode node)
        {
            base.Visit(node);
        }

        public override void Visit(AST.SubtractExpressionNode node)
        {
            base.Visit(node);
        }

        public override void Visit(AST.MultiplyExpressionNode node)
        {
            base.Visit(node);
        }

        public override void Visit(AST.NewIntegerArrayExpressionNode node)
        {
            base.Visit(node);
        }

        public override void Visit(AST.NewObjectExpressionNode node)
        {
            base.Visit(node);
        }

        public override void Visit(AST.IdentifierExpressionNode node)
        {
            base.Visit(node);
        }

        public override void Visit(AST.ArrayLookupExpressionNode node)
        {
            base.Visit(node);
        }

        public override void Visit(AST.LengthExpressionNode node)
        {
            base.Visit(node);
        }

        public override void Visit(AST.MethodCallExpressionNode node)
        {
            base.Visit(node);
        }

        public override void Visit(AST.FieldAccessExpressionNode node)
        {
            base.Visit(node);
        }

        public override void Visit(AST.ThisExpressionNode node)
        {
            base.Visit(node);
        }

        public override void Visit(AST.NotExpressionNode node)
        {
            base.Visit(node);
        }

        public override void Visit(AST.AndExpressionNode node)
        {
            base.Visit(node);
        }

        public override void Visit(AST.LessThanExpressionNode node)
        {
            base.Visit(node);
        }
        #endregion

        #region Statement
        public override void Visit(AST.SystemOutPrintLnStatementNode node)
        {
            base.Visit(node);
        }

        public override void Visit(AST.ReturnStatementNode node)
        {
            base.Visit(node);
        }

        public override void Visit(AST.AssignmentStatementNode node)
        {
            base.Visit(node);
        }

        public override void Visit(AST.ArrayAssignmentStatementNode node)
        {
            base.Visit(node);
        }

        public override void Visit(AST.FieldAssignmentStatementNode node)
        {
            base.Visit(node);
        }

        public override void Visit(AST.WhileStatementNode node)
        {
            base.Visit(node);
        }

        public override void Visit(AST.IfStatementNode node)
        {
            base.Visit(node);
        }
        #endregion

        #endregion
    }
}