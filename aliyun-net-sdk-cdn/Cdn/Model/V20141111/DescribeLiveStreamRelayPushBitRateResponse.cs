/*
 * Licensed to the Apache Software Foundation (ASF) under one
 * or more contributor license agreements.  See the NOTICE file
 * distributed with this work for additional information
 * regarding copyright ownership.  The ASF licenses this file
 * to you under the Apache License, Version 2.0 (the
 * "License"); you may not use this file except in compliance
 * with the License.  You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing,
 * software distributed under the License is distributed on an
 * "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
 * KIND, either express or implied.  See the License for the
 * specific language governing permissions and limitations
 * under the License.
 */
using Aliyun.Acs.Core;
using System.Collections.Generic;

namespace Aliyun.Acs.Cdn.Model.V20141111
{
	public class DescribeLiveStreamRelayPushBitRateResponse : AcsResponse
	{

		private string requestId;

		private List<DescribeLiveStreamRelayPushBitRate_RelayPushBitRateModel> relayPushBitRateModelList;

		public string RequestId
		{
			get
			{
				return requestId;
			}
			set	
			{
				requestId = value;
			}
		}

		public List<DescribeLiveStreamRelayPushBitRate_RelayPushBitRateModel> RelayPushBitRateModelList
		{
			get
			{
				return relayPushBitRateModelList;
			}
			set	
			{
				relayPushBitRateModelList = value;
			}
		}

		public class DescribeLiveStreamRelayPushBitRate_RelayPushBitRateModel
		{

			private string time;

			private string vedioFrame;

			private string vedioTimstamp;

			private string audioFrame;

			private string audioTimstamp;

			private string relayDomain;

			public string Time
			{
				get
				{
					return time;
				}
				set	
				{
					time = value;
				}
			}

			public string VedioFrame
			{
				get
				{
					return vedioFrame;
				}
				set	
				{
					vedioFrame = value;
				}
			}

			public string VedioTimstamp
			{
				get
				{
					return vedioTimstamp;
				}
				set	
				{
					vedioTimstamp = value;
				}
			}

			public string AudioFrame
			{
				get
				{
					return audioFrame;
				}
				set	
				{
					audioFrame = value;
				}
			}

			public string AudioTimstamp
			{
				get
				{
					return audioTimstamp;
				}
				set	
				{
					audioTimstamp = value;
				}
			}

			public string RelayDomain
			{
				get
				{
					return relayDomain;
				}
				set	
				{
					relayDomain = value;
				}
			}
		}
	}
}