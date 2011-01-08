#region license
// Copyright (c) 2009 Rodrigo B. de Oliveira (rbo@acm.org)
// All rights reserved.
// 
// Redistribution and use in source and binary forms, with or without modification,
// are permitted provided that the following conditions are met:
// 
//     * Redistributions of source code must retain the above copyright notice,
//     this list of conditions and the following disclaimer.
//     * Redistributions in binary form must reproduce the above copyright notice,
//     this list of conditions and the following disclaimer in the documentation
//     and/or other materials provided with the distribution.
//     * Neither the name of Rodrigo B. de Oliveira nor the names of its
//     contributors may be used to endorse or promote products derived from this
//     software without specific prior written permission.
// 
// THIS SOFTWARE IS PROVIDED BY THE COPYRIGHT HOLDERS AND CONTRIBUTORS "AS IS" AND
// ANY EXPRESS OR IMPLIED WARRANTIES, INCLUDING, BUT NOT LIMITED TO, THE IMPLIED
// WARRANTIES OF MERCHANTABILITY AND FITNESS FOR A PARTICULAR PURPOSE ARE
// DISCLAIMED. IN NO EVENT SHALL THE COPYRIGHT OWNER OR CONTRIBUTORS BE LIABLE
// FOR ANY DIRECT, INDIRECT, INCIDENTAL, SPECIAL, EXEMPLARY, OR CONSEQUENTIAL
// DAMAGES (INCLUDING, BUT NOT LIMITED TO, PROCUREMENT OF SUBSTITUTE GOODS OR
// SERVICES; LOSS OF USE, DATA, OR PROFITS; OR BUSINESS INTERRUPTION) HOWEVER
// CAUSED AND ON ANY THEORY OF LIABILITY, WHETHER IN CONTRACT, STRICT LIABILITY,
// OR TORT (INCLUDING NEGLIGENCE OR OTHERWISE) ARISING IN ANY WAY OUT OF THE USE OF
// THIS SOFTWARE, EVEN IF ADVISED OF THE POSSIBILITY OF SUCH DAMAGE.
#endregion

//
// DO NOT EDIT THIS FILE!
//
// This file was generated automatically by astgen.boo.
//
namespace Boo.Lang.Compiler.Ast
{	
	using System.Collections;
	using System.Runtime.Serialization;
	
	[System.Serializable]
	public partial class EnumDefinition : TypeDefinition
	{

		[System.CodeDom.Compiler.GeneratedCodeAttribute("astgen.boo", "1")]
		new public EnumDefinition CloneNode()
		{
			return (EnumDefinition)Clone();
		}
		
		/// <summary>
		/// <see cref="Node.CleanClone"/>
		/// </summary>
		[System.CodeDom.Compiler.GeneratedCodeAttribute("astgen.boo", "1")]
		new public EnumDefinition CleanClone()
		{
			return (EnumDefinition)base.CleanClone();
		}

		[System.CodeDom.Compiler.GeneratedCodeAttribute("astgen.boo", "1")]
		override public NodeType NodeType
		{
			get { return NodeType.EnumDefinition; }
		}

		[System.CodeDom.Compiler.GeneratedCodeAttribute("astgen.boo", "1")]
		override public void Accept(IAstVisitor visitor)
		{
			visitor.OnEnumDefinition(this);
		}

		[System.CodeDom.Compiler.GeneratedCodeAttribute("astgen.boo", "1")]
		override public bool Matches(Node node)
		{	
			if (node == null) return false;
			if (NodeType != node.NodeType) return false;
			var other = ( EnumDefinition)node;
			if (_modifiers != other._modifiers) return NoMatch("EnumDefinition._modifiers");
			if (_name != other._name) return NoMatch("EnumDefinition._name");
			if (!Node.AllMatch(_attributes, other._attributes)) return NoMatch("EnumDefinition._attributes");
			if (!Node.AllMatch(_members, other._members)) return NoMatch("EnumDefinition._members");
			if (!Node.AllMatch(_baseTypes, other._baseTypes)) return NoMatch("EnumDefinition._baseTypes");
			if (!Node.AllMatch(_genericParameters, other._genericParameters)) return NoMatch("EnumDefinition._genericParameters");
			return true;
		}

		[System.CodeDom.Compiler.GeneratedCodeAttribute("astgen.boo", "1")]
		override public bool Replace(Node existing, Node newNode)
		{
			if (base.Replace(existing, newNode))
			{
				return true;
			}
			if (_attributes != null)
			{
				Attribute item = existing as Attribute;
				if (null != item)
				{
					Attribute newItem = (Attribute)newNode;
					if (_attributes.Replace(item, newItem))
					{
						return true;
					}
				}
			}
			if (_members != null)
			{
				TypeMember item = existing as TypeMember;
				if (null != item)
				{
					TypeMember newItem = (TypeMember)newNode;
					if (_members.Replace(item, newItem))
					{
						return true;
					}
				}
			}
			if (_baseTypes != null)
			{
				TypeReference item = existing as TypeReference;
				if (null != item)
				{
					TypeReference newItem = (TypeReference)newNode;
					if (_baseTypes.Replace(item, newItem))
					{
						return true;
					}
				}
			}
			if (_genericParameters != null)
			{
				GenericParameterDeclaration item = existing as GenericParameterDeclaration;
				if (null != item)
				{
					GenericParameterDeclaration newItem = (GenericParameterDeclaration)newNode;
					if (_genericParameters.Replace(item, newItem))
					{
						return true;
					}
				}
			}
			return false;
		}

		[System.CodeDom.Compiler.GeneratedCodeAttribute("astgen.boo", "1")]
		override public object Clone()
		{
			EnumDefinition clone = (EnumDefinition)FormatterServices.GetUninitializedObject(typeof(EnumDefinition));
			clone._lexicalInfo = _lexicalInfo;
			clone._endSourceLocation = _endSourceLocation;
			clone._documentation = _documentation;
			clone._entity = _entity;
			if (_annotations != null) clone._annotations = (Hashtable)_annotations.Clone();
		
			clone._modifiers = _modifiers;
			clone._name = _name;
			if (null != _attributes)
			{
				clone._attributes = _attributes.Clone() as AttributeCollection;
				clone._attributes.InitializeParent(clone);
			}
			if (null != _members)
			{
				clone._members = _members.Clone() as TypeMemberCollection;
				clone._members.InitializeParent(clone);
			}
			if (null != _baseTypes)
			{
				clone._baseTypes = _baseTypes.Clone() as TypeReferenceCollection;
				clone._baseTypes.InitializeParent(clone);
			}
			if (null != _genericParameters)
			{
				clone._genericParameters = _genericParameters.Clone() as GenericParameterDeclarationCollection;
				clone._genericParameters.InitializeParent(clone);
			}
			return clone;
		}

		[System.CodeDom.Compiler.GeneratedCodeAttribute("astgen.boo", "1")]
		override internal void ClearTypeSystemBindings()
		{
			_annotations = null;
			_entity = null;
			if (null != _attributes)
			{
				_attributes.ClearTypeSystemBindings();
			}
			if (null != _members)
			{
				_members.ClearTypeSystemBindings();
			}
			if (null != _baseTypes)
			{
				_baseTypes.ClearTypeSystemBindings();
			}
			if (null != _genericParameters)
			{
				_genericParameters.ClearTypeSystemBindings();
			}

		}
	

	}
}

