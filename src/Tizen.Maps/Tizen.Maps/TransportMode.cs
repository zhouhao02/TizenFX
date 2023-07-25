﻿/*
 * Copyright (c) 2016 Samsung Electronics Co., Ltd All Rights Reserved
 *
 * Licensed under the Apache License, Version 2.0 (the License);
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 * http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an AS IS BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

using System;

namespace Tizen.Maps
{
    /// <summary>
    /// Route types.
    /// </summary>
    /// <since_tizen> 3 </since_tizen>
    [Obsolete("Deprecated since API11. Might be removed in API13.")]
    public enum TransportMode
    {
        /// <summary>
        /// Indicates that the route is to be traveled by a car.
        /// </summary>
        Car = Interop.RouteTransportMode.Car,
        /// <summary>
        /// Indicates that the route is for a pedestrian.
        /// </summary>
        Pedestrian = Interop.RouteTransportMode.Pedestrian,
        /// <summary>
        /// Indicates that the route is for a cyclist.
        /// </summary>
        Bicycle = Interop.RouteTransportMode.Bicycle,
        /// <summary>
        /// Indicates that the route is to be traveled using public transport.
        /// </summary>
        /// <since_tizen> 4 </since_tizen>
        PublicTransit = Interop.RouteTransportMode.PublicTransit,
        /// <summary>
        /// Indicates that the route is for a truck.
        /// </summary>
        Truck = Interop.RouteTransportMode.Truck,
    }
}
