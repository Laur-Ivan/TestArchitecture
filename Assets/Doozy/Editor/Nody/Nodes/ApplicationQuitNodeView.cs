// Copyright (c) 2015 - 2021 Doozy Entertainment. All Rights Reserved.
// This code can only be used under the standard Unity Asset Store End User License Agreement
// A Copy of the EULA APPENDIX 1 is available at http://unity3d.com/company/legal/as_terms

using System;
using System.Collections.Generic;
using Doozy.Editor.EditorUI;
using Doozy.Runtime.Nody;
using Doozy.Runtime.Nody.Nodes;
using UnityEngine;

namespace Doozy.Editor.Nody.Nodes
{
    public class ApplicationQuitNodeView : FlowNodeView
    {
        public override Type nodeType => typeof(ApplicationQuitNode);
        public override IEnumerable<Texture2D> nodeIconTextures => EditorMicroAnimations.Nody.Icons.ApplicationQuitNode;

        public ApplicationQuitNodeView(FlowGraphView graphView, FlowNode node) : base(graphView, node)
        {
        }
    }
}