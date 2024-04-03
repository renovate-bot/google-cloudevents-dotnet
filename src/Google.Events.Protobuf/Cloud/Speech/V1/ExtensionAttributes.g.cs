// Copyright 2024, Google LLC
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

namespace Google.Events.Protobuf.Cloud.Speech.V1
{    
    /// <summary>Extension attributes for Google.Events.Protobuf.Cloud.Speech.V1 events.</summary>
    public static class ExtensionAttributes
    {
        /// <summary>
        /// <para>The resource ID of the CustomClass triggering the event.</para>
        ///
        /// <para>This is used by the following events:</para>
        ///
        /// <list type="bullet">
        ///   <item><description>google.cloud.speech.customClass.v1.created</description></item>
        ///   <item><description>google.cloud.speech.customClass.v1.updated</description></item>
        ///   <item><description>google.cloud.speech.customClass.v1.deleted</description></item>
        /// </list>
        /// </summary>
        public static CloudEventAttribute CustomClass { get; } = CloudEventAttribute.CreateExtension("customclass", CloudEventAttributeType.String);

        /// <summary>
        /// <para>The resource ID of the PhraseSet triggering the event.</para>
        ///
        /// <para>This is used by the following events:</para>
        ///
        /// <list type="bullet">
        ///   <item><description>google.cloud.speech.phraseSet.v1.created</description></item>
        ///   <item><description>google.cloud.speech.phraseSet.v1.updated</description></item>
        ///   <item><description>google.cloud.speech.phraseSet.v1.deleted</description></item>
        /// </list>
        /// </summary>
        public static CloudEventAttribute PhraseSet { get; } = CloudEventAttribute.CreateExtension("phraseset", CloudEventAttributeType.String);

    }
}