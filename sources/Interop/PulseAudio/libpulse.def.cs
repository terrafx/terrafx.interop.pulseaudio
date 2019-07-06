using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public enum pa_context_state : uint
    {
        PA_CONTEXT_UNCONNECTED,
        PA_CONTEXT_CONNECTING,
        PA_CONTEXT_AUTHORIZING,
        PA_CONTEXT_SETTING_NAME,
        PA_CONTEXT_READY,
        PA_CONTEXT_FAILED,
        PA_CONTEXT_TERMINATED,
    }

    public enum pa_stream_state : uint
    {
        PA_STREAM_UNCONNECTED,
        PA_STREAM_CREATING,
        PA_STREAM_READY,
        PA_STREAM_FAILED,
        PA_STREAM_TERMINATED,
    }

    public enum pa_operation_state : uint
    {
        PA_OPERATION_RUNNING,
        PA_OPERATION_DONE,
        PA_OPERATION_CANCELLED,
    }

    public enum pa_context_flags : uint
    {
        PA_CONTEXT_NOFLAGS = 0x0000U,
        PA_CONTEXT_NOAUTOSPAWN = 0x0001U,
        PA_CONTEXT_NOFAIL = 0x0002U,
    }

    public enum pa_direction : uint
    {
        PA_DIRECTION_OUTPUT = 0x0001U,
        PA_DIRECTION_INPUT = 0x0002U,
    }

    public enum pa_device_type : uint
    {
        PA_DEVICE_TYPE_SINK,
        PA_DEVICE_TYPE_SOURCE,
    }

    public enum pa_stream_direction : uint
    {
        PA_STREAM_NODIRECTION,
        PA_STREAM_PLAYBACK,
        PA_STREAM_RECORD,
        PA_STREAM_UPLOAD,
    }

    public enum pa_stream_flags : uint
    {
        PA_STREAM_NOFLAGS = 0x0000U,
        PA_STREAM_START_CORKED = 0x0001U,
        PA_STREAM_INTERPOLATE_TIMING = 0x0002U,
        PA_STREAM_NOT_MONOTONIC = 0x0004U,
        PA_STREAM_AUTO_TIMING_UPDATE = 0x0008U,
        PA_STREAM_NO_REMAP_CHANNELS = 0x0010U,
        PA_STREAM_NO_REMIX_CHANNELS = 0x0020U,
        PA_STREAM_FIX_FORMAT = 0x0040U,
        PA_STREAM_FIX_RATE = 0x0080U,
        PA_STREAM_FIX_CHANNELS = 0x0100,
        PA_STREAM_DONT_MOVE = 0x0200U,
        PA_STREAM_VARIABLE_RATE = 0x0400U,
        PA_STREAM_PEAK_DETECT = 0x0800U,
        PA_STREAM_START_MUTED = 0x1000U,
        PA_STREAM_ADJUST_LATENCY = 0x2000U,
        PA_STREAM_EARLY_REQUESTS = 0x4000U,
        PA_STREAM_DONT_INHIBIT_AUTO_SUSPEND = 0x8000U,
        PA_STREAM_START_UNMUTED = 0x10000U,
        PA_STREAM_FAIL_ON_SUSPEND = 0x20000U,
        PA_STREAM_RELATIVE_VOLUME = 0x40000U,
        PA_STREAM_PASSTHROUGH = 0x80000U,
    }

    public partial struct pa_buffer_attr
    {
        [NativeTypeName("uint32_t")]
        public uint maxlength;

        [NativeTypeName("uint32_t")]
        public uint tlength;

        [NativeTypeName("uint32_t")]
        public uint prebuf;

        [NativeTypeName("uint32_t")]
        public uint minreq;

        [NativeTypeName("uint32_t")]
        public uint fragsize;
    }

    public enum pa_error_code : uint
    {
        PA_OK = 0,
        PA_ERR_ACCESS,
        PA_ERR_COMMAND,
        PA_ERR_INVALID,
        PA_ERR_EXIST,
        PA_ERR_NOENTITY,
        PA_ERR_CONNECTIONREFUSED,
        PA_ERR_PROTOCOL,
        PA_ERR_TIMEOUT,
        PA_ERR_AUTHKEY,
        PA_ERR_INTERNAL,
        PA_ERR_CONNECTIONTERMINATED,
        PA_ERR_KILLED,
        PA_ERR_INVALIDSERVER,
        PA_ERR_MODINITFAILED,
        PA_ERR_BADSTATE,
        PA_ERR_NODATA,
        PA_ERR_VERSION,
        PA_ERR_TOOLARGE,
        PA_ERR_NOTSUPPORTED,
        PA_ERR_UNKNOWN,
        PA_ERR_NOEXTENSION,
        PA_ERR_OBSOLETE,
        PA_ERR_NOTIMPLEMENTED,
        PA_ERR_FORKED,
        PA_ERR_IO,
        PA_ERR_BUSY,
        PA_ERR_MAX,
    }

    public enum pa_subscription_mask : uint
    {
        PA_SUBSCRIPTION_MASK_NULL = 0x0000U,
        PA_SUBSCRIPTION_MASK_SINK = 0x0001U,
        PA_SUBSCRIPTION_MASK_SOURCE = 0x0002U,
        PA_SUBSCRIPTION_MASK_SINK_INPUT = 0x0004U,
        PA_SUBSCRIPTION_MASK_SOURCE_OUTPUT = 0x0008U,
        PA_SUBSCRIPTION_MASK_MODULE = 0x0010U,
        PA_SUBSCRIPTION_MASK_CLIENT = 0x0020U,
        PA_SUBSCRIPTION_MASK_SAMPLE_CACHE = 0x0040U,
        PA_SUBSCRIPTION_MASK_SERVER = 0x0080U,
        PA_SUBSCRIPTION_MASK_AUTOLOAD = 0x0100U,
        PA_SUBSCRIPTION_MASK_CARD = 0x0200U,
        PA_SUBSCRIPTION_MASK_ALL = 0x02ffU,
    }

    public enum pa_subscription_event_type : uint
    {
        PA_SUBSCRIPTION_EVENT_SINK = 0x0000U,
        PA_SUBSCRIPTION_EVENT_SOURCE = 0x0001U,
        PA_SUBSCRIPTION_EVENT_SINK_INPUT = 0x0002U,
        PA_SUBSCRIPTION_EVENT_SOURCE_OUTPUT = 0x0003U,
        PA_SUBSCRIPTION_EVENT_MODULE = 0x0004U,
        PA_SUBSCRIPTION_EVENT_CLIENT = 0x0005U,
        PA_SUBSCRIPTION_EVENT_SAMPLE_CACHE = 0x0006U,
        PA_SUBSCRIPTION_EVENT_SERVER = 0x0007U,
        PA_SUBSCRIPTION_EVENT_AUTOLOAD = 0x0008U,
        PA_SUBSCRIPTION_EVENT_CARD = 0x0009U,
        PA_SUBSCRIPTION_EVENT_FACILITY_MASK = 0x000FU,
        PA_SUBSCRIPTION_EVENT_NEW = 0x0000U,
        PA_SUBSCRIPTION_EVENT_CHANGE = 0x0010U,
        PA_SUBSCRIPTION_EVENT_REMOVE = 0x0020U,
        PA_SUBSCRIPTION_EVENT_TYPE_MASK = 0x0030U,
    }

    public partial struct pa_timing_info
    {
        [NativeTypeName("struct timeval")]
        public timeval timestamp;

        public int synchronized_clocks;

        [NativeTypeName("pa_usec_t")]
        public UIntPtr sink_usec;

        [NativeTypeName("pa_usec_t")]
        public UIntPtr source_usec;

        [NativeTypeName("pa_usec_t")]
        public UIntPtr transport_usec;

        public int playing;

        public int write_index_corrupt;

        [NativeTypeName("int64_t")]
        public IntPtr write_index;

        public int read_index_corrupt;

        [NativeTypeName("int64_t")]
        public IntPtr read_index;

        [NativeTypeName("pa_usec_t")]
        public UIntPtr configured_sink_usec;

        [NativeTypeName("pa_usec_t")]
        public UIntPtr configured_source_usec;

        [NativeTypeName("int64_t")]
        public IntPtr since_underrun;
    }

    public partial struct pa_spawn_api
    {
        [NativeTypeName("void (*)()")]
        public IntPtr prefork;

        [NativeTypeName("void (*)()")]
        public IntPtr postfork;

        [NativeTypeName("void (*)()")]
        public IntPtr atfork;
    }

    public enum pa_seek_mode : uint
    {
        PA_SEEK_RELATIVE = 0,
        PA_SEEK_ABSOLUTE = 1,
        PA_SEEK_RELATIVE_ON_READ = 2,
        PA_SEEK_RELATIVE_END = 3,
    }

    public enum pa_sink_flags : uint
    {
        PA_SINK_NOFLAGS = 0x0000U,
        PA_SINK_HW_VOLUME_CTRL = 0x0001U,
        PA_SINK_LATENCY = 0x0002U,
        PA_SINK_HARDWARE = 0x0004U,
        PA_SINK_NETWORK = 0x0008U,
        PA_SINK_HW_MUTE_CTRL = 0x0010U,
        PA_SINK_DECIBEL_VOLUME = 0x0020U,
        PA_SINK_FLAT_VOLUME = 0x0040U,
        PA_SINK_DYNAMIC_LATENCY = 0x0080U,
        PA_SINK_SET_FORMATS = 0x0100U,
    }

    public enum pa_sink_state
    {
        PA_SINK_INVALID_STATE = -1,
        PA_SINK_RUNNING = 0,
        PA_SINK_IDLE = 1,
        PA_SINK_SUSPENDED = 2,
        PA_SINK_INIT = -2,
        PA_SINK_UNLINKED = -3,
    }

    public enum pa_source_flags : uint
    {
        PA_SOURCE_NOFLAGS = 0x0000U,
        PA_SOURCE_HW_VOLUME_CTRL = 0x0001U,
        PA_SOURCE_LATENCY = 0x0002U,
        PA_SOURCE_HARDWARE = 0x0004U,
        PA_SOURCE_NETWORK = 0x0008U,
        PA_SOURCE_HW_MUTE_CTRL = 0x0010U,
        PA_SOURCE_DECIBEL_VOLUME = 0x0020U,
        PA_SOURCE_DYNAMIC_LATENCY = 0x0040U,
        PA_SOURCE_FLAT_VOLUME = 0x0080U,
    }

    public enum pa_source_state
    {
        PA_SOURCE_INVALID_STATE = -1,
        PA_SOURCE_RUNNING = 0,
        PA_SOURCE_IDLE = 1,
        PA_SOURCE_SUSPENDED = 2,
        PA_SOURCE_INIT = -2,
        PA_SOURCE_UNLINKED = -3,
    }

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate void pa_free_cb_t([NativeTypeName("void *")] void* p);

    public enum pa_port_available : uint
    {
        PA_PORT_AVAILABLE_UNKNOWN = 0,
        PA_PORT_AVAILABLE_NO = 1,
        PA_PORT_AVAILABLE_YES = 2,
    }

    public static partial class pulse
    {
        public static bool PA_CONTEXT_IS_GOOD([NativeTypeName("pa_context_state_t")] pa_context_state x)
        {
            return x == pa_context_state.PA_CONTEXT_CONNECTING
                || x == pa_context_state.PA_CONTEXT_AUTHORIZING
                || x == pa_context_state.PA_CONTEXT_SETTING_NAME
                || x == pa_context_state.PA_CONTEXT_READY;
        }

        public static bool PA_STREAM_IS_GOOD([NativeTypeName("pa_stream_state_t")] pa_stream_state x)
        {
            return x == pa_stream_state.PA_STREAM_CREATING
                || x == pa_stream_state.PA_STREAM_READY;
        }

        public static bool PA_SINK_IS_OPENED([NativeTypeName("pa_sink_state_t")] pa_sink_state x)
        {
            return x == pa_sink_state.PA_SINK_RUNNING
                || x == pa_sink_state.PA_SINK_IDLE;
        }

        public static bool PA_SINK_IS_RUNNING([NativeTypeName("pa_sink_state_t")] pa_sink_state x)
        {
            return x == pa_sink_state.PA_SINK_RUNNING;
        }

        public static bool PA_SOURCE_IS_OPENED([NativeTypeName("pa_source_state_t")] pa_source_state x)
        {
            return x == pa_source_state.PA_SOURCE_RUNNING
                || x == pa_source_state.PA_SOURCE_IDLE;
        }

        public static bool PA_SOURCE_IS_RUNNING([NativeTypeName("pa_source_state_t")] pa_source_state x)
        {
            return x == pa_source_state.PA_SOURCE_RUNNING;
        }
    }
}
