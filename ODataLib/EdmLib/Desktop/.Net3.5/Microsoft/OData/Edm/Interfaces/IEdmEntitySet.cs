//   OData .NET Libraries
//   Copyright (c) Microsoft Corporation
//   All rights reserved. 

//   Licensed under the Apache License, Version 2.0 (the ""License""); you may not use this file except in compliance with the License. You may obtain a copy of the License at http://www.apache.org/licenses/LICENSE-2.0 

//   THIS CODE IS PROVIDED ON AN  *AS IS* BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, EITHER EXPRESS OR IMPLIED, INCLUDING WITHOUT LIMITATION ANY IMPLIED WARRANTIES OR CONDITIONS OF TITLE, FITNESS FOR A PARTICULAR PURPOSE, MERCHANTABLITY OR NON-INFRINGEMENT. 

//   See the Apache Version 2.0 License for specific language governing permissions and limitations under the License.

using System.Collections.Generic;

namespace Microsoft.OData.Edm
{
    /// <summary>
    /// Represents an EDM entity set.
    /// </summary>
    public interface IEdmEntitySet : IEdmEntityContainerElement
    {
        /// <summary>
        /// Gets the entity type contained in this entity set.
        /// </summary>
        IEdmEntityType ElementType { get; }

        /// <summary>
        /// Gets the navigation targets of this entity set.
        /// </summary>
        IEnumerable<IEdmNavigationTargetMapping> NavigationTargets { get; }

        /// <summary>
        /// Finds the entity set that a navigation property targets.
        /// </summary>
        /// <param name="navigationProperty">The navigation property.</param>
        /// /// <returns>The entity set that the navigation propertion targets, or null if no such entity set exists.</returns>
        IEdmEntitySet FindNavigationTarget(IEdmNavigationProperty navigationProperty);
    }
}