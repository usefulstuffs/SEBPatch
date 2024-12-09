﻿/*
 * Copyright (c) 2024 ETH Zürich, IT Services
 * 
 * This Source Code Form is subject to the terms of the Mozilla Public
 * License, v. 2.0. If a copy of the MPL was not distributed with this
 * file, You can obtain one at http://mozilla.org/MPL/2.0/.
 */

namespace SafeExamBrowser.Proctoring.Contracts.Events
{
	/// <summary>
	/// Event handler used to indicate that the remaining work status has been updated.
	/// </summary>
	public delegate void RemainingWorkUpdatedEventHandler(RemainingWorkUpdatedEventArgs args);
}
