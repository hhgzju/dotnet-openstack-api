﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cloudbase.OpenstackNova
{
    public enum InstanceStatus
    {
        ACTIVE,                      // The server is active.
        BUILD,                      // The server has not finished the original build process.
        DELETED,                   // The server is deleted.
        ERROR,                    // The server is in error.
        HARD_REBOOT,             // The server is hard rebooting. This is equivalent to pulling the power plug on a physical server, plugging it back in, and rebooting it.
        PASSWORD,               // The password is being reset on the server.
        REBOOT,                // The server is in a soft reboot state. A reboot command was passed to the operating system.
        REBUILD,              // The server is currently being rebuilt from an image.
        RESCUE,             // The server is in rescue mode.
        RESIZE,            //Server is performing the differential copy of data that changed during its initial copy. Server is down for this stage.
        REVERT_RESIZE,    // The resize or migration of a server failed for some reason. The destination server is being cleaned up and the original source server is restarting.
        SHUTOFF,         //The virtual machine (VM) was powered down by the user, but not through the OpenStack Compute API. For example, the user issued a shutdown -h command from within the server instance. If the OpenStack Compute manager detects that the VM was powered down, it transitions the server instance to the SHUTOFF status. If you use the OpenStack Compute API to restart the instance, the instance might be deleted first, depending on the value in the shutdown_terminate database field on the Instance model.
        SUSPENDED,      // The server is suspended, either by request or necessity. This status appears for only the following hypervisors: XenServer/XCP, KVM, and ESXi. Review support tickets or contact Rackspace support to determine why the server is in this state.
        UNKNOWN,       // The state of the server is unknown. Contact your cloud provider.
        VERIFY_RESIZE,// System is awaiting confirmation that the server is operational after a move or resize.
    }


}
