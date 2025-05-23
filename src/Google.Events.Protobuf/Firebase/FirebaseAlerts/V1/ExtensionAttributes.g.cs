// Copyright 2025, Google LLC
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     https://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

using CloudNative.CloudEvents;

namespace Google.Events.Protobuf.Firebase.FirebaseAlerts.V1
{    
    /// <summary>Extension attributes for Google.Events.Protobuf.Firebase.FirebaseAlerts.V1 events.</summary>
    public static class ExtensionAttributes
    {
        /// <summary>
        /// <para>The type of the alerts that got triggered.</para>
        ///
        /// <para>This is used by the following events:</para>
        ///
        /// <list type="bullet">
        ///   <item><description>google.firebase.firebasealerts.alerts.v1.published</description></item>
        /// </list>
        /// </summary>
        public static CloudEventAttribute AlertType { get; } = CloudEventAttribute.CreateExtension("alerttype", CloudEventAttributeType.String);

        /// <summary>
        /// <para>The Firebase App ID that’s associated with the alert. This is optional, and only present when the alert is targeting at a specific Firebase App.</para>
        ///
        /// <para>This is used by the following events:</para>
        ///
        /// <list type="bullet">
        ///   <item><description>google.firebase.firebasealerts.alerts.v1.published</description></item>
        /// </list>
        /// </summary>
        public static CloudEventAttribute AppId { get; } = CloudEventAttribute.CreateExtension("appid", CloudEventAttributeType.String);

    }
}
