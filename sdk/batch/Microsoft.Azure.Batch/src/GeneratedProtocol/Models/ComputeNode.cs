// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Batch.Protocol.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// A Compute Node in the Batch service.
    /// </summary>
    public partial class ComputeNode
    {
        /// <summary>
        /// Initializes a new instance of the ComputeNode class.
        /// </summary>
        public ComputeNode()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ComputeNode class.
        /// </summary>
        /// <param name="id">The ID of the Compute Node.</param>
        /// <param name="url">The URL of the Compute Node.</param>
        /// <param name="state">The current state of the Compute Node.</param>
        /// <param name="schedulingState">Whether the Compute Node is available
        /// for Task scheduling.</param>
        /// <param name="stateTransitionTime">The time at which the Compute
        /// Node entered its current state.</param>
        /// <param name="lastBootTime">The last time at which the Compute Node
        /// was started.</param>
        /// <param name="allocationTime">The time at which this Compute Node
        /// was allocated to the Pool.</param>
        /// <param name="ipAddress">The IP address that other Nodes can use to
        /// communicate with this Compute Node.</param>
        /// <param name="affinityId">An identifier which can be passed when
        /// adding a Task to request that the Task be scheduled on this Compute
        /// Node.</param>
        /// <param name="vmSize">The size of the virtual machine hosting the
        /// Compute Node.</param>
        /// <param name="totalTasksRun">The total number of Job Tasks completed
        /// on the Compute Node. This includes Job Manager Tasks and normal
        /// Tasks, but not Job Preparation, Job Release or Start Tasks.</param>
        /// <param name="runningTasksCount">The total number of currently
        /// running Job Tasks on the Compute Node. This includes Job Manager
        /// Tasks and normal Tasks, but not Job Preparation, Job Release or
        /// Start Tasks.</param>
        /// <param name="runningTaskSlotsCount">The total number of scheduling
        /// slots used by currently running Job Tasks on the Compute Node. This
        /// includes Job Manager Tasks and normal Tasks, but not Job
        /// Preparation, Job Release or Start Tasks.</param>
        /// <param name="totalTasksSucceeded">The total number of Job Tasks
        /// which completed successfully (with exitCode 0) on the Compute Node.
        /// This includes Job Manager Tasks and normal Tasks, but not Job
        /// Preparation, Job Release or Start Tasks.</param>
        /// <param name="recentTasks">A list of Tasks whose state has recently
        /// changed.</param>
        /// <param name="startTask">The Task specified to run on the Compute
        /// Node as it joins the Pool.</param>
        /// <param name="startTaskInfo">Runtime information about the execution
        /// of the StartTask on the Compute Node.</param>
        /// <param name="certificateReferences">The list of Certificates
        /// installed on the Compute Node.</param>
        /// <param name="errors">The list of errors that are currently being
        /// encountered by the Compute Node.</param>
        /// <param name="isDedicated">Whether this Compute Node is a dedicated
        /// Compute Node. If false, the Compute Node is a low-priority Compute
        /// Node.</param>
        /// <param name="endpointConfiguration">The endpoint configuration for
        /// the Compute Node.</param>
        /// <param name="nodeAgentInfo">Information about the Compute Node
        /// agent version and the time the Compute Node upgraded to a new
        /// version.</param>
        /// <param name="virtualMachineInfo">Info about the current state of
        /// the virtual machine.</param>
        public ComputeNode(string id = default(string), string url = default(string), ComputeNodeState? state = default(ComputeNodeState?), SchedulingState? schedulingState = default(SchedulingState?), System.DateTime? stateTransitionTime = default(System.DateTime?), System.DateTime? lastBootTime = default(System.DateTime?), System.DateTime? allocationTime = default(System.DateTime?), string ipAddress = default(string), string affinityId = default(string), string vmSize = default(string), int? totalTasksRun = default(int?), int? runningTasksCount = default(int?), int? runningTaskSlotsCount = default(int?), int? totalTasksSucceeded = default(int?), IList<TaskInformation> recentTasks = default(IList<TaskInformation>), StartTask startTask = default(StartTask), StartTaskInformation startTaskInfo = default(StartTaskInformation), IList<CertificateReference> certificateReferences = default(IList<CertificateReference>), IList<ComputeNodeError> errors = default(IList<ComputeNodeError>), bool? isDedicated = default(bool?), ComputeNodeEndpointConfiguration endpointConfiguration = default(ComputeNodeEndpointConfiguration), NodeAgentInformation nodeAgentInfo = default(NodeAgentInformation), VirtualMachineInfo virtualMachineInfo = default(VirtualMachineInfo))
        {
            Id = id;
            Url = url;
            State = state;
            SchedulingState = schedulingState;
            StateTransitionTime = stateTransitionTime;
            LastBootTime = lastBootTime;
            AllocationTime = allocationTime;
            IpAddress = ipAddress;
            AffinityId = affinityId;
            VmSize = vmSize;
            TotalTasksRun = totalTasksRun;
            RunningTasksCount = runningTasksCount;
            RunningTaskSlotsCount = runningTaskSlotsCount;
            TotalTasksSucceeded = totalTasksSucceeded;
            RecentTasks = recentTasks;
            StartTask = startTask;
            StartTaskInfo = startTaskInfo;
            CertificateReferences = certificateReferences;
            Errors = errors;
            IsDedicated = isDedicated;
            EndpointConfiguration = endpointConfiguration;
            NodeAgentInfo = nodeAgentInfo;
            VirtualMachineInfo = virtualMachineInfo;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the ID of the Compute Node.
        /// </summary>
        /// <remarks>
        /// Every Compute Node that is added to a Pool is assigned a unique ID.
        /// Whenever a Compute Node is removed from a Pool, all of its local
        /// files are deleted, and the ID is reclaimed and could be reused for
        /// new Compute Nodes.
        /// </remarks>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets the URL of the Compute Node.
        /// </summary>
        [JsonProperty(PropertyName = "url")]
        public string Url { get; set; }

        /// <summary>
        /// Gets or sets the current state of the Compute Node.
        /// </summary>
        /// <remarks>
        /// The low-priority Compute Node has been preempted. Tasks which were
        /// running on the Compute Node when it was preempted will be
        /// rescheduled when another Compute Node becomes available. Possible
        /// values include: 'idle', 'rebooting', 'reimaging', 'running',
        /// 'unusable', 'creating', 'starting', 'waitingForStartTask',
        /// 'startTaskFailed', 'unknown', 'leavingPool', 'offline', 'preempted'
        /// </remarks>
        [JsonProperty(PropertyName = "state")]
        public ComputeNodeState? State { get; set; }

        /// <summary>
        /// Gets or sets whether the Compute Node is available for Task
        /// scheduling.
        /// </summary>
        /// <remarks>
        /// Possible values include: 'enabled', 'disabled'
        /// </remarks>
        [JsonProperty(PropertyName = "schedulingState")]
        public SchedulingState? SchedulingState { get; set; }

        /// <summary>
        /// Gets or sets the time at which the Compute Node entered its current
        /// state.
        /// </summary>
        [JsonProperty(PropertyName = "stateTransitionTime")]
        public System.DateTime? StateTransitionTime { get; set; }

        /// <summary>
        /// Gets or sets the last time at which the Compute Node was started.
        /// </summary>
        /// <remarks>
        /// This property may not be present if the Compute Node state is
        /// unusable.
        /// </remarks>
        [JsonProperty(PropertyName = "lastBootTime")]
        public System.DateTime? LastBootTime { get; set; }

        /// <summary>
        /// Gets or sets the time at which this Compute Node was allocated to
        /// the Pool.
        /// </summary>
        /// <remarks>
        /// This is the time when the Compute Node was initially allocated and
        /// doesn't change once set. It is not updated when the Compute Node is
        /// service healed or preempted.
        /// </remarks>
        [JsonProperty(PropertyName = "allocationTime")]
        public System.DateTime? AllocationTime { get; set; }

        /// <summary>
        /// Gets or sets the IP address that other Nodes can use to communicate
        /// with this Compute Node.
        /// </summary>
        /// <remarks>
        /// Every Compute Node that is added to a Pool is assigned a unique IP
        /// address. Whenever a Compute Node is removed from a Pool, all of its
        /// local files are deleted, and the IP address is reclaimed and could
        /// be reused for new Compute Nodes.
        /// </remarks>
        [JsonProperty(PropertyName = "ipAddress")]
        public string IpAddress { get; set; }

        /// <summary>
        /// Gets or sets an identifier which can be passed when adding a Task
        /// to request that the Task be scheduled on this Compute Node.
        /// </summary>
        /// <remarks>
        /// Note that this is just a soft affinity. If the target Compute Node
        /// is busy or unavailable at the time the Task is scheduled, then the
        /// Task will be scheduled elsewhere.
        /// </remarks>
        [JsonProperty(PropertyName = "affinityId")]
        public string AffinityId { get; set; }

        /// <summary>
        /// Gets or sets the size of the virtual machine hosting the Compute
        /// Node.
        /// </summary>
        /// <remarks>
        /// For information about available sizes of virtual machines in Pools,
        /// see Choose a VM size for Compute Nodes in an Azure Batch Pool
        /// (https://docs.microsoft.com/azure/batch/batch-pool-vm-sizes).
        /// </remarks>
        [JsonProperty(PropertyName = "vmSize")]
        public string VmSize { get; set; }

        /// <summary>
        /// Gets or sets the total number of Job Tasks completed on the Compute
        /// Node. This includes Job Manager Tasks and normal Tasks, but not Job
        /// Preparation, Job Release or Start Tasks.
        /// </summary>
        [JsonProperty(PropertyName = "totalTasksRun")]
        public int? TotalTasksRun { get; set; }

        /// <summary>
        /// Gets or sets the total number of currently running Job Tasks on the
        /// Compute Node. This includes Job Manager Tasks and normal Tasks, but
        /// not Job Preparation, Job Release or Start Tasks.
        /// </summary>
        [JsonProperty(PropertyName = "runningTasksCount")]
        public int? RunningTasksCount { get; set; }

        /// <summary>
        /// Gets or sets the total number of scheduling slots used by currently
        /// running Job Tasks on the Compute Node. This includes Job Manager
        /// Tasks and normal Tasks, but not Job Preparation, Job Release or
        /// Start Tasks.
        /// </summary>
        [JsonProperty(PropertyName = "runningTaskSlotsCount")]
        public int? RunningTaskSlotsCount { get; set; }

        /// <summary>
        /// Gets or sets the total number of Job Tasks which completed
        /// successfully (with exitCode 0) on the Compute Node. This includes
        /// Job Manager Tasks and normal Tasks, but not Job Preparation, Job
        /// Release or Start Tasks.
        /// </summary>
        [JsonProperty(PropertyName = "totalTasksSucceeded")]
        public int? TotalTasksSucceeded { get; set; }

        /// <summary>
        /// Gets or sets a list of Tasks whose state has recently changed.
        /// </summary>
        /// <remarks>
        /// This property is present only if at least one Task has run on this
        /// Compute Node since it was assigned to the Pool.
        /// </remarks>
        [JsonProperty(PropertyName = "recentTasks")]
        public IList<TaskInformation> RecentTasks { get; set; }

        /// <summary>
        /// Gets or sets the Task specified to run on the Compute Node as it
        /// joins the Pool.
        /// </summary>
        [JsonProperty(PropertyName = "startTask")]
        public StartTask StartTask { get; set; }

        /// <summary>
        /// Gets or sets runtime information about the execution of the
        /// StartTask on the Compute Node.
        /// </summary>
        [JsonProperty(PropertyName = "startTaskInfo")]
        public StartTaskInformation StartTaskInfo { get; set; }

        /// <summary>
        /// Gets or sets the list of Certificates installed on the Compute
        /// Node.
        /// </summary>
        /// <remarks>
        /// For Windows Nodes, the Batch service installs the Certificates to
        /// the specified Certificate store and location. For Linux Compute
        /// Nodes, the Certificates are stored in a directory inside the Task
        /// working directory and an environment variable
        /// AZ_BATCH_CERTIFICATES_DIR is supplied to the Task to query for this
        /// location. For Certificates with visibility of 'remoteUser', a
        /// 'certs' directory is created in the user's home directory (e.g.,
        /// /home/{user-name}/certs) and Certificates are placed in that
        /// directory.
        /// </remarks>
        [JsonProperty(PropertyName = "certificateReferences")]
        public IList<CertificateReference> CertificateReferences { get; set; }

        /// <summary>
        /// Gets or sets the list of errors that are currently being
        /// encountered by the Compute Node.
        /// </summary>
        [JsonProperty(PropertyName = "errors")]
        public IList<ComputeNodeError> Errors { get; set; }

        /// <summary>
        /// Gets or sets whether this Compute Node is a dedicated Compute Node.
        /// If false, the Compute Node is a low-priority Compute Node.
        /// </summary>
        [JsonProperty(PropertyName = "isDedicated")]
        public bool? IsDedicated { get; set; }

        /// <summary>
        /// Gets or sets the endpoint configuration for the Compute Node.
        /// </summary>
        [JsonProperty(PropertyName = "endpointConfiguration")]
        public ComputeNodeEndpointConfiguration EndpointConfiguration { get; set; }

        /// <summary>
        /// Gets or sets information about the Compute Node agent version and
        /// the time the Compute Node upgraded to a new version.
        /// </summary>
        [JsonProperty(PropertyName = "nodeAgentInfo")]
        public NodeAgentInformation NodeAgentInfo { get; set; }

        /// <summary>
        /// Gets or sets info about the current state of the virtual machine.
        /// </summary>
        [JsonProperty(PropertyName = "virtualMachineInfo")]
        public VirtualMachineInfo VirtualMachineInfo { get; set; }

    }
}
