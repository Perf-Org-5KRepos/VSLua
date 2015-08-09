﻿using LanguageModel.Tests.TestGeneration;
using LanguageService;
using Xunit;
namespace LanguageModel.Tests.GeneratedTestFiles
{
    class LucaDemo_Generated
    {
        [Fact]
        public void Test(Tester t)
        {
            t.N(SyntaxKind.ChunkNode);
            {
                t.N(SyntaxKind.BlockNode);
                {
                    t.N(SyntaxKind.AssignmentStatementNode);
                    {
                        t.N(SyntaxKind.VarList);
                        {
                            t.N(SyntaxKind.NameVar);
                            {
                                t.N(SyntaxKind.Identifier);
                            }
                        }
                        t.N(SyntaxKind.AssignmentOperator);
                        t.N(SyntaxKind.ExpList);
                        {
                            t.N(SyntaxKind.SimpleExpression);
                            {
                                t.N(SyntaxKind.Number);
                            }
                        }
                    }
                    t.N(SyntaxKind.AssignmentStatementNode);
                    {
                        t.N(SyntaxKind.VarList);
                        {
                            t.N(SyntaxKind.NameVar);
                            {
                                t.N(SyntaxKind.Identifier);
                            }
                        }
                        t.N(SyntaxKind.AssignmentOperator);
                        t.N(SyntaxKind.ExpList);
                        {
                            t.N(SyntaxKind.FunctionDef);
                            {
                                t.N(SyntaxKind.FunctionKeyword);
                                t.N(SyntaxKind.FuncBodyNode);
                                {
                                    t.N(SyntaxKind.OpenParen);
                                    t.N(SyntaxKind.NameListPar);
                                    {
                                        t.N(SyntaxKind.NameList);
                                        {
                                            t.N(SyntaxKind.Identifier);
                                            t.N(SyntaxKind.Comma);
                                            t.N(SyntaxKind.Identifier);
                                        }
                                    }
                                    t.N(SyntaxKind.CloseParen);
                                    t.N(SyntaxKind.BlockNode);
                                    {
                                        t.N(SyntaxKind.ReturnStatementNode);
                                        {
                                            t.N(SyntaxKind.ReturnKeyword);
                                            t.N(SyntaxKind.ExpList);
                                            {
                                                t.N(SyntaxKind.BinaryOperatorExpression);
                                                {
                                                    t.N(SyntaxKind.NameVar);
                                                    {
                                                        t.N(SyntaxKind.Identifier);
                                                    }
                                                    t.N(SyntaxKind.PlusOperator);
                                                    t.N(SyntaxKind.NameVar);
                                                    {
                                                        t.N(SyntaxKind.Identifier);
                                                    }
                                                }
                                            }
                                        }
                                        t.N(SyntaxKind.SemiColonStatementNode);
                                        {
                                            t.N(SyntaxKind.Semicolon);
                                        }
                                    }
                                    t.N(SyntaxKind.EndKeyword);
                                }
                            }
                        }
                    }
                    t.N(SyntaxKind.AssignmentStatementNode);
                    {
                        t.N(SyntaxKind.VarList);
                        {
                            t.N(SyntaxKind.NameVar);
                            {
                                t.N(SyntaxKind.Identifier);
                            }
                        }
                        t.N(SyntaxKind.AssignmentOperator);
                        t.N(SyntaxKind.ExpList);
                        {
                            t.N(SyntaxKind.FunctionDef);
                            {
                                t.N(SyntaxKind.FunctionKeyword);
                                t.N(SyntaxKind.FuncBodyNode);
                                {
                                    t.N(SyntaxKind.OpenParen);
                                    t.N(SyntaxKind.NameListPar);
                                    {
                                        t.N(SyntaxKind.NameList);
                                    }
                                    t.N(SyntaxKind.CloseParen);
                                    t.N(SyntaxKind.BlockNode);
                                    {
                                        t.N(SyntaxKind.ReturnStatementNode);
                                        {
                                            t.N(SyntaxKind.ReturnKeyword);
                                            t.N(SyntaxKind.ExpList);
                                            {
                                                t.N(SyntaxKind.SimpleExpression);
                                                {
                                                    t.N(SyntaxKind.Number);
                                                }
                                            }
                                        }
                                    }
                                    t.N(SyntaxKind.EndKeyword);
                                }
                            }
                        }
                    }
                }
                t.N(SyntaxKind.EndOfFile);
            }
        }
    }
}
