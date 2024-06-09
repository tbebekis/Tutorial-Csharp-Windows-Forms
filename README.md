C# Windows Forms Applications
==========================


- [C# Windows Forms Applications](#c-windows-forms-applications)
    - [Introduction to Windows Forms](#introduction-to-windows-forms)
      - [IDE and tools](#ide-and-tools)
        - [Form Designer](#form-designer)
        - [Property Grid](#property-grid)
        - [Toolbox](#toolbox)
        - [Code editor](#code-editor)
      - [Creating a Windows Forms application](#creating-a-windows-forms-application)
      - [The Program class and the Main() method](#the-program-class-and-the-main-method)
      - [Messages and events](#messages-and-events)
      - [Screen class](#screen-class)
      - [SystemInformation class](#systeminformation-class)
      - [Environment class](#environment-class)
      - [OSFeature class](#osfeature-class)
      - [PowerStatus class](#powerstatus-class)
    - [Application class, application types and Forms](#application-class-application-types-and-forms)
      - [The static Application class](#the-static-application-class)
      - [The Main Form and the ApplicationContext class](#the-main-form-and-the-applicationcontext-class)
      - [Multiple Document Interface (MDI) applications](#multiple-document-interface-mdi-applications)
      - [Single Document Interface (SDI) applications](#single-document-interface-sdi-applications)
        - [The Owner property](#the-owner-property)
      - [Modal forms](#modal-forms)
      - [The Form.Close() case](#the-formclose-case)
      - [The power of the visual form inheritance](#the-power-of-the-visual-form-inheritance)
    - [Components and Controls](#components-and-controls)
      - [Component class and Control Class](#component-class-and-control-class)
      - [Parentship](#parentship)
      - [Screen and client coordinates](#screen-and-client-coordinates)
      - [The Form class](#the-form-class)
      - [The Form Designer as a code generation tool](#the-form-designer-as-a-code-generation-tool)
    - [Control common properties and operations](#control-common-properties-and-operations)
      - [Layout](#layout)
      - [The Point, Rectangle and Size structs](#the-point-rectangle-and-size-structs)
        - [Point struct](#point-struct)
        - [Rectangle struct](#rectangle-struct)
        - [Size struct](#size-struct)
      - [Control position and size](#control-position-and-size)
        - [Size constraints](#size-constraints)
        - [Client and non-client area](#client-and-non-client-area)
        - [The Z-order](#the-z-order)
      - [Dock and Anchor properties](#dock-and-anchor-properties)
      - [Control common appearance properties](#control-common-appearance-properties)
        - [Colors](#colors)
        - [Text](#text)
        - [Font](#font)
        - [Cursor](#cursor)
      - [Ambient properties](#ambient-properties)
      - [ToolTip component and extender providers](#tooltip-component-and-extender-providers)
      - [TabIndex and TabStop properties](#tabindex-and-tabstop-properties)
    - [Windows messages](#windows-messages)
      - [Message processing in Windows Forms](#message-processing-in-windows-forms)
        - [IMessageFilter](#imessagefilter)
        - [Control.PreProcessMessage()](#controlpreprocessmessage)
        - [Control.WndProc()](#controlwndproc)
        - [Control.DefWndProc()](#controldefwndproc)
        - [Control.OnNotifyMessage()](#controlonnotifymessage)
      - [Windows and the NativeWindow class](#windows-and-the-nativewindow-class)
    - [User input](#user-input)
      - [Keyboard input](#keyboard-input)
        - [Form.KeyPrieview property](#formkeyprieview-property)
      - [The KeyCrack helper class](#the-keycrack-helper-class)
      - [Preprocessing keys](#preprocessing-keys)
        - [KeyDown event preprocessing](#keydown-event-preprocessing)
        - [KeyPress event preprocessing](#keypress-event-preprocessing)
      - [Processing keys](#processing-keys)
      - [The Keyboard class and the SendKeys class](#the-keyboard-class-and-the-sendkeys-class)
      - [Mouse input](#mouse-input)
        - [Hit-testing](#hit-testing)
      - [Mouse capture](#mouse-capture)
      - [Mouse events](#mouse-events)
      - [Mouse clicks](#mouse-clicks)
      - [Mouse move](#mouse-move)
    - [Drag and drop](#drag-and-drop)
      - [The drag source](#the-drag-source)
      - [The drop target](#the-drop-target)
      - [Drag and drop examples](#drag-and-drop-examples)
      - [Clipboard class](#clipboard-class)
    - [Validation and the ErrorProvider component](#validation-and-the-errorprovider-component)
    - [Windows Forms built-in controls and components](#windows-forms-built-in-controls-and-components)
      - [Buttons](#buttons)
        - [Button](#button)
        - [CheckBox](#checkbox)
        - [RadioButton](#radiobutton)
      - [TextBox](#textbox)
      - [MaskedTextBox](#maskedtextbox)
      - [RichTextBox](#richtextbox)
      - [List controls: ComboBox, ListBox and CheckedListBox](#list-controls-combobox-listbox-and-checkedlistbox)
        - [ComboBox](#combobox)
        - [ListBox](#listbox)
        - [CheckedListBox](#checkedlistbox)
      - [ProgressBar](#progressbar)
      - [MonthCalendar](#monthcalendar)
      - [DateTimePicker](#datetimepicker)
      - [NumericUpDown](#numericupdown)
      - [ListView](#listview)
      - [TreeView](#treeview)
      - [Dialog boxes](#dialog-boxes)
      - [PictureBox](#picturebox)
      - [Menus, tool bars and status bars](#menus-tool-bars-and-status-bars)
      - [Other standard controls and components](#other-standard-controls-and-components)
        - [Label and LinkLabel](#label-and-linklabel)
        - [DataGridView](#datagridview)
        - [DataGrid](#datagrid)
        - [WebBrowser](#webbrowser)
        - [ImageList](#imagelist)
        - [Timer](#timer)
        - [NotifyIcon](#notifyicon)
      - [The remarkable UserControl control](#the-remarkable-usercontrol-control)
    - [Configuration: application and user settings](#configuration-application-and-user-settings)
      - [Configuration files](#configuration-files)
      - [Accessing configuration settings by code](#accessing-configuration-settings-by-code)
    - [Application resources](#application-resources)
      - [Adding resources to a project](#adding-resources-to-a-project)
      - [Accessing resources by code at runtime](#accessing-resources-by-code-at-runtime)
    - [World-ready applications](#world-ready-applications)
      - [The notion of culture and the CultureInfo class](#the-notion-of-culture-and-the-cultureinfo-class)
      - [Invariant, neutral and specific cultures](#invariant-neutral-and-specific-cultures)
      - [Culture hierarchy](#culture-hierarchy)
      - [Application culture](#application-culture)
        - [CurrentUICulture](#currentuiculture)
        - [CurrentCulture](#currentculture)
      - [User overrides](#user-overrides)
      - [RegionInfo class](#regioninfo-class)
      - [Custom cultures and the CultureAndRegionInfoBuilder class](#custom-cultures-and-the-cultureandregioninfobuilder-class)
      - ["There Ain't No Such Thing As Plain Text" (as Joel Spolsky said)](#there-aint-no-such-thing-as-plain-text-as-joel-spolsky-said)
        - [ASCII](#ascii)
        - [OEM character sets](#oem-character-sets)
        - [ANSI code pages](#ansi-code-pages)
        - [Double-byte and Multi-byte character sets](#double-byte-and-multi-byte-character-sets)
        - [Unicode](#unicode)
        - [Encodings](#encodings)
      - [Encoding class](#encoding-class)
        - [Encoding and decoding operations](#encoding-and-decoding-operations)
      - [About CLR strings and characters](#about-clr-strings-and-characters)
      - [TextInfo class](#textinfo-class)
      - [String comparison](#string-comparison)
        - [Comparison operations use the culture of the current thread](#comparison-operations-use-the-culture-of-the-current-thread)
        - [Three different ways of comparing and sorting strings](#three-different-ways-of-comparing-and-sorting-strings)
      - [NumberFormatInfo class](#numberformatinfo-class)
      - [DateTimeFormatInfo class](#datetimeformatinfo-class)
      - [Calendar class](#calendar-class)
        - [Other classes related to date and time](#other-classes-related-to-date-and-time)
    - [Localization: making a multi-lingual application](#localization-making-a-multi-lingual-application)
      - [Localizing a form](#localizing-a-form)
      - [Localizing general string resources](#localizing-general-string-resources)
      - [Setting application culture](#setting-application-culture)
      - [Localization tools](#localization-tools)
      - [](#)
          - [Copyright � 2009 Theodoros Bebekis, Thessaloniki, Greece (teo point bebekis at gmail point com)](#copyright--2009-theodoros-bebekis-thessaloniki-greece-teo-point-bebekis-at-gmail-point-com)

 

 
### Introduction to Windows Forms

A Windows Forms application is an application that uses top level windows, known as forms, and common user interface controls, such as buttons and text boxes, in order to interact with the end user. That kind of application is known as desktop application (in contrast to web applications which are HTML-based applications).

.Net provides rich functionality to help in creating desktop applications. Most of the classes and types used in creating desktop applications reside in the System.Windows.Forms namespace.

#### IDE and tools

The MS Visual Studio IDE (Integrated Development Environment) is a RAD (Rapid Application Development) IDE and it provides a number of tools for building windows-based applications rapidly.

##### Form Designer

Provides a design surface where the user drops and arranges controls in order to build a form.

##### Property Grid

Displays the public properties of the currently selected control or controls, allowing the user to customize the appearance and behavior of that control. It also displays a list of the available events for the control. Double clicking on an event name, creates an empty event handler.

##### Toolbox

Displays lists of available controls and components. The user drags items from that box and drops them on the Form Designer.

##### Code editor

A state of the art text edit control for writing user code.

#### Creating a Windows Forms application

The MS Visual Studio provides a wizard for creating a new Windows Forms project. That wizard is accessible by right clicking the Solution in the Solution Explorer and then Add | New Project | Visual C# | Windows | Windows Forms Application.

The wizard creates a new project which contains just a single Form.

Additional Forms can be added by right clicking the project in the Solution Explorer and then Add | Windows Form.

#### The Program class and the Main() method

Along with the single Form, the new project wizard creates the Program class in the Program.cs source file.

    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }

NOTE: For an explanation of the STAThread attribute see the Threading tutorial.

The static Program class contains the required static Main() method which is the main entry point of the application. The Main() method may have arguments passed to it. Those arguments are known as command line arguments. The wizard omits the parameter but the user can it them manually.

    static void Main(string[] Args)
    {    
        string S = "";
        foreach (string arg in Args)
            S += arg + Environment.NewLine;

        MessageBox.Show(S);
            
        Application.EnableVisualStyles();
        Application.SetCompatibleTextRenderingDefault(false);
        Application.Run(new MainForm());
    }

The command line arguments passed to Main() method is a string array. The full path to the executable is not included in those command line arguments. Thus for a normal application without command line arguments the Args.Length is zero.

There is nothing magic or mandatory to that Program class. That class is part of the housekeeping the new project wizard does. The sole requirement is that the application must contain a single static Main() method.

NOTE: Right clicking on a project in the Solution Explorer and then Properties | Debug displays, among others, a "Command line arguments" text box, where the user can set command line arguments for debug purposes.

#### Messages and events

Windows sends messages to applications. Without windows messages an application has no idea of user input, such as mouse or keyboard input, or any other activity.

Messages sent to an application are in fact turned into events, exposed by the various controls. The programmer attaches event handlers, that is methods, to those events and writes code to handle them.

While an event handler is executed the application is busy executing that event handler code and has no chance to see if new messages are sent by the system. So, long running event handlers can make the application unresponsive to user actions. The Application.DoEvents() method allows the application to handle any messages came in between.

    private void button1_Click(object sender, EventArgs e)
    {
        if (!looping)
        {
            looping = true;

            for (int i = 0; i < int.MaxValue / 2; i++)
                if (i % 5000 == 0)
                    Application.DoEvents();

            looping = false;

            MessageBox.Show("Done!");
        }
    }
    

In above example, commenting the call

    Application.DoEvents();

results in an unresponsive application for as long as the button1_Click() executes.

There could be more than one event handlers attached to a single event. In fact attaching an event handler to an event can be done manually.

    button1.Click += new EventHandler(AnotherButtonClickEventHandler);
    
    ...
    
    void AnotherButtonClickEventHandler(object sender, EventArgs e)
    {
        MessageBox.Show("Hello from AnotherButtonClickEventHandler!");
    } 
    

NOTE: The C# language tutorial provides more information regarding events and the C# class model in general.

#### Screen class

The System.Windows.Forms.Screen class provides information about the display device.

    public class Screen
    {
        public static Screen[] AllScreens { get; }
        public int BitsPerPixel { get; }
        public Rectangle Bounds { get; }
        public string DeviceName { get; }
        public bool Primary { get; }
        public static Screen PrimaryScreen { get; }
        public Rectangle WorkingArea { get; }

        public override bool Equals(object obj);
        public static Screen FromControl(Control control);
        public static Screen FromHandle(IntPtr hwnd);
        public static Screen FromPoint(Point point);
        public static Screen FromRectangle(Rectangle rect);
        public static Rectangle GetBounds(Control ctl);
        public static Rectangle GetBounds(Point pt);
        public static Rectangle GetBounds(Rectangle rect);
        public override int GetHashCode();
        public static Rectangle GetWorkingArea(Control ctl);
        public static Rectangle GetWorkingArea(Point pt);
        public static Rectangle GetWorkingArea(Rectangle rect);
        public override string ToString();
    }

#### SystemInformation class

The System.Windows.Forms.SystemInformation class provides information regarding the current system.

    public class SystemInformation
    {
        public static int ActiveWindowTrackingDelay { get; }
        public static ArrangeDirection ArrangeDirection { get; }
        public static ArrangeStartingPosition ArrangeStartingPosition { get; }
        public static BootMode BootMode { get; }
        public static Size Border3DSize { get; }
        public static int BorderMultiplierFactor { get; }
        public static Size BorderSize { get; }
        public static Size CaptionButtonSize { get; }
        public static int CaptionHeight { get; }
        public static int CaretBlinkTime { get; }
        public static int CaretWidth { get; }
        public static string ComputerName { get; }
        public static Size CursorSize { get; }
        public static bool DbcsEnabled { get; }
        public static bool DebugOS { get; }
        public static Size DoubleClickSize { get; }
        public static int DoubleClickTime { get; }
        public static bool DragFullWindows { get; }
        public static Size DragSize { get; }
        public static Size FixedFrameBorderSize { get; }
        public static int FontSmoothingContrast { get; }
        public static int FontSmoothingType { get; }
        public static Size FrameBorderSize { get; }
        public static bool HighContrast { get; }
        public static int HorizontalFocusThickness { get; }
        public static int HorizontalResizeBorderThickness { get; }
        public static int HorizontalScrollBarArrowWidth { get; }
        public static int HorizontalScrollBarHeight { get; }
        public static int HorizontalScrollBarThumbWidth { get; }
        public static int IconHorizontalSpacing { get; }
        public static Size IconSize { get; }
        public static Size IconSpacingSize { get; }
        public static int IconVerticalSpacing { get; }
        public static bool IsActiveWindowTrackingEnabled { get; }
        public static bool IsComboBoxAnimationEnabled { get; }
        public static bool IsDropShadowEnabled { get; }
        public static bool IsFlatMenuEnabled { get; }
        public static bool IsFontSmoothingEnabled { get; }
        public static bool IsHotTrackingEnabled { get; }
        public static bool IsIconTitleWrappingEnabled { get; }
        public static bool IsKeyboardPreferred { get; }
        public static bool IsListBoxSmoothScrollingEnabled { get; }
        public static bool IsMenuAnimationEnabled { get; }
        public static bool IsMenuFadeEnabled { get; }
        public static bool IsMinimizeRestoreAnimationEnabled { get; }
        public static bool IsSelectionFadeEnabled { get; }
        public static bool IsSnapToDefaultEnabled { get; }
        public static bool IsTitleBarGradientEnabled { get; }
        public static bool IsToolTipAnimationEnabled { get; }
        public static int KanjiWindowHeight { get; }
        public static int KeyboardDelay { get; }
        public static int KeyboardSpeed { get; }
        public static Size MaxWindowTrackSize { get; }
        public static bool MenuAccessKeysUnderlined { get; }
        public static Size MenuBarButtonSize { get; }
        public static Size MenuButtonSize { get; }
        public static Size MenuCheckSize { get; }
        public static Font MenuFont { get; }
        public static int MenuHeight { get; }
        public static int MenuShowDelay { get; }
        public static bool MidEastEnabled { get; }
        public static Size MinimizedWindowSize { get; }
        public static Size MinimizedWindowSpacingSize { get; }
        public static Size MinimumWindowSize { get; }
        public static Size MinWindowTrackSize { get; }
        public static int MonitorCount { get; }
        public static bool MonitorsSameDisplayFormat { get; }
        public static int MouseButtons { get; }
        public static bool MouseButtonsSwapped { get; }
        public static Size MouseHoverSize { get; }
        public static int MouseHoverTime { get; }
        public static bool MousePresent { get; }
        public static int MouseSpeed { get; }
        public static bool MouseWheelPresent { get; }
        public static int MouseWheelScrollDelta { get; }
        public static int MouseWheelScrollLines { get; }
        public static bool NativeMouseWheelSupport { get; }
        public static bool Network { get; }
        public static bool PenWindows { get; }
        public static LeftRightAlignment PopupMenuAlignment { get; }
        public static PowerStatus PowerStatus { get; }
        public static Size PrimaryMonitorMaximizedWindowSize { get; }
        public static Size PrimaryMonitorSize { get; }
        public static bool RightAlignedMenus { get; }
        public static ScreenOrientation ScreenOrientation { get; }
        public static bool Secure { get; }
        public static bool ShowSounds { get; }
        public static int SizingBorderWidth { get; }
        public static Size SmallCaptionButtonSize { get; }
        public static Size SmallIconSize { get; }
        public static bool TerminalServerSession { get; }
        public static Size ToolWindowCaptionButtonSize { get; }
        public static int ToolWindowCaptionHeight { get; }
        public static bool UIEffectsEnabled { get; }
        public static string UserDomainName { get; }
        public static bool UserInteractive { get; }
        public static string UserName { get; }
        public static int VerticalFocusThickness { get; }
        public static int VerticalResizeBorderThickness { get; }
        public static int VerticalScrollBarArrowHeight { get; }
        public static int VerticalScrollBarThumbHeight { get; }
        public static int VerticalScrollBarWidth { get; }
        public static Rectangle VirtualScreen { get; }
        public static Rectangle WorkingArea { get; }
    }  

#### Environment class

Another useful class that provides information about the current environment and platform is the System.Environment class.

    public static class Environment
    {
        public static string CommandLine { get; }
        public static string CurrentDirectory { get; set; }
        public static int ExitCode { get; set; }
        public static bool HasShutdownStarted { get; }
        public static string MachineName { get; }
        public static string NewLine { get; }
        public static OperatingSystem OSVersion { get; }
        public static int ProcessorCount { get; }
        public static string StackTrace { get; }
        public static string SystemDirectory { get; }
        public static int TickCount { get; }
        public static string UserDomainName { get; }
        public static bool UserInteractive { get; }
        public static string UserName { get; }
        public static Version Version { get; }
        public static long WorkingSet { get; }

        public static void Exit(int exitCode);
        public static string ExpandEnvironmentVariables(string name);
        public static void FailFast(string message);
        public static string[] GetCommandLineArgs();
        public static string GetEnvironmentVariable(string variable);
        public static string GetEnvironmentVariable(string variable, EnvironmentVariableTarget target);
        public static IDictionary GetEnvironmentVariables();
        public static IDictionary GetEnvironmentVariables(EnvironmentVariableTarget target);
        public static string GetFolderPath(Environment.SpecialFolder folder);
        public static string[] GetLogicalDrives();
        public static void SetEnvironmentVariable(string variable, string value);
        public static void SetEnvironmentVariable(string variable, string value, EnvironmentVariableTarget target);

        public enum SpecialFolder
        {
            Desktop = 0,
            Programs = 2,
            Personal = 5,
            MyDocuments = 5,
            Favorites = 6,
            Startup = 7,
            Recent = 8,
            SendTo = 9,
            StartMenu = 11,
            MyMusic = 13,
            DesktopDirectory = 16,
            MyComputer = 17,
            Templates = 21,
            ApplicationData = 26,
            LocalApplicationData = 28,
            InternetCache = 32,
            Cookies = 33,
            History = 34,
            CommonApplicationData = 35,
            System = 37,
            ProgramFiles = 38,
            MyPictures = 39,
            CommonProgramFiles = 43,
        }
    }
    

Among other properties the Environment class provides a CommandLine string property.

        private void button2_Click(object sender, EventArgs e)
        {
            string S = "";
            S += string.Format("CommandLine: {0}", Environment.CommandLine) + Environment.NewLine;
            S += string.Format("CurrentDirectory: {0}", Environment.CurrentDirectory) + Environment.NewLine;
            S += string.Format("MachineName: {0}", Environment.MachineName) + Environment.NewLine;
            S += string.Format("OSVersion: {0}", Environment.OSVersion) + Environment.NewLine;
            S += string.Format("SystemDirectory: {0}", Environment.SystemDirectory) + Environment.NewLine;
            S += string.Format("UserDomainName: {0}", Environment.UserDomainName) + Environment.NewLine;
            S += string.Format("UserName: {0}", Environment.UserName) + Environment.NewLine;
            S += string.Format(".Net Version: {0}", Environment.Version) + Environment.NewLine;

            MessageBox.Show(S);
        }

#### OSFeature class

The System.Windows.Forms.OSFeature class inherits from System.Windows.Forms.FeatureSupport class, is used to query for operating system features.

    public abstract class FeatureSupport : IFeatureSupport
    {
        protected FeatureSupport();

        public abstract Version GetVersionPresent(object feature);
        public static Version GetVersionPresent(string featureClassName, string featureConstName);
        public virtual bool IsPresent(object feature);
        public virtual bool IsPresent(object feature, Version minimumVersion);
        public static bool IsPresent(string featureClassName, string featureConstName);
        public static bool IsPresent(string featureClassName, string featureConstName, Version minimumVersion);
    }


    public class OSFeature : FeatureSupport
    {
        public static readonly object LayeredWindows;
        public static readonly object Themes;

        protected OSFeature();

        public static OSFeature Feature { get; }

        public override Version GetVersionPresent(object feature);
        public static bool IsPresent(SystemParameter enumVal);
    }

The OSFeature class can be used to check if LayeredWindows or Themes are supported by the operating system. There is one version of the overloaded IsPresent() method that can be used with the static fields of the OSFeature class and another version that can be used with System.Windows.Forms.SystemParameter enum values.

    public enum SystemParameter
    {
        DropShadow = 0,
        FlatMenu = 1,
        FontSmoothingContrastMetric = 2,
        FontSmoothingTypeMetric = 3,
        MenuFadeEnabled = 4,
        SelectionFade = 5,
        ToolTipAnimationMetric = 6,
        UIEffects = 7,
        CaretWidthMetric = 8,
        VerticalFocusThicknessMetric = 9,
        HorizontalFocusThicknessMetric = 10,
    }
    

Here is an example

    if (OSFeature.Feature.IsPresent(OSFeature.LayeredWindows))
        MessageBox.Show("supports LayeredWindows!");   
        
    if (OSFeature.Feature.IsPresent(SystemParameter.DropShadow))
        MessageBox.Show("supports DropShadow!");   
            

#### PowerStatus class

The System.Windows.Forms.PowerStatus class provides power status information.

    public class PowerStatus
    {
        public BatteryChargeStatus BatteryChargeStatus { get; }
        public int BatteryFullLifetime { get; }
        public float BatteryLifePercent { get; }
        public int BatteryLifeRemaining { get; }
        public PowerLineStatus PowerLineStatus { get; }
    }

The SystemInformation class provides a PowerStatus property.

Here is an example.

    if (SystemInformation.PowerStatus.PowerLineStatus == PowerLineStatus.Offline)
        if (SystemInformation.PowerStatus.BatteryChargeStatus == BatteryChargeStatus.Low)
            MessageBox.Show("Battery is low!");

### Application class, application types and Forms

The System.Windows.Forms.Application class is the center of a Windows Forms application.

There are two types of Windows Forms applications: Single Document Interface (SDI) and Multiple Document Interface (MDI) applications.

A Windows Forms application may contain any number of Forms. One of those forms is considered as the main form of the application and it has a special function.

#### The static Application class

The static System.Windows.Forms.Application class contains many useful properties and methods.

    public sealed class Application
    {
        public static bool AllowQuit { get; }
        public static string CommonAppDataPath { get; }
        public static RegistryKey CommonAppDataRegistry { get; }
        public static string CompanyName { get; }
        public static CultureInfo CurrentCulture { get; set; }
        public static InputLanguage CurrentInputLanguage { get; set; }
        public static string ExecutablePath { get; }
        public static string LocalUserAppDataPath { get; }
        public static bool MessageLoop { get; }
        public static FormCollection OpenForms { get; }
        public static string ProductName { get; }
        public static string ProductVersion { get; }
        public static bool RenderWithVisualStyles { get; }
        public static string SafeTopLevelCaptionFormat { get; set; }
        public static string StartupPath { get; }
        public static string UserAppDataPath { get; }
        public static RegistryKey UserAppDataRegistry { get; }
        public static bool UseWaitCursor { get; set; }
        public static VisualStyleState VisualStyleState { get; set; }

        public static event EventHandler ApplicationExit;
        public static event EventHandler EnterThreadModal;
        public static event EventHandler Idle;
        public static event EventHandler LeaveThreadModal;
        public static event ThreadExceptionEventHandler ThreadException;
        public static event EventHandler ThreadExit;

        public static void AddMessageFilter(IMessageFilter value);
        public static void DoEvents();
        public static void EnableVisualStyles();
        public static void Exit();
        public static void Exit(CancelEventArgs e);
        public static void ExitThread();
        public static bool FilterMessage(ref Message message);
        public static ApartmentState OleRequired();
        public static void OnThreadException(Exception t);
        public static void RaiseIdle(EventArgs e);
        public static void RegisterMessageLoop(Application.MessageLoopCallback callback);
        public static void RemoveMessageFilter(IMessageFilter value);
        public static void Restart();
        public static void Run();
        public static void Run(ApplicationContext context);
        public static void Run(Form mainForm);
        public static void SetCompatibleTextRenderingDefault(bool defaultValue);
        public static bool SetSuspendState(PowerState state, bool force, bool disableWakeEvent);
        public static void SetUnhandledExceptionMode(UnhandledExceptionMode mode);
        public static void SetUnhandledExceptionMode(UnhandledExceptionMode mode, bool threadScope);
        public static void UnregisterMessageLoop();

        public delegate bool MessageLoopCallback();
    }

As the Threading tutorial explains, when an application starts a thread is created too. That thread is known as the primary thread or the main thread or the user interface thread and is the thread that handles the user interface by creating and handling forms and controls.

Windows messages sent to an application are processed in a so-called message loop, which is executed in the context of the primary thread, and which is the place where most of those windows messages are eventually turned into events. The Application.Run() method ignites that message loop.

#### The Main Form and the ApplicationContext class

There is an Application.Run() overload which accepts a Form object. That form becomes the Main Form of the application.

    public static void Run(Form mainForm);

Another way to set the Main Form is to use the Application.Run() overload that gets an an instance of the System.Windows.Forms.ApplicationContext class.

    public static void Run(ApplicationContext context);

The System.Windows.Forms.ApplicationContext class provides a read-write MainForm property.

    public class ApplicationContext : IDisposable
    {
        public ApplicationContext();
        public ApplicationContext(Form mainForm);

        public Form MainForm { get; set; }
        public object Tag { get; set; }

        public event EventHandler ThreadExit;

        public void Dispose();
        public void ExitThread();
    }
    

Here is a possible use of the ApplicationContext.

        [STAThread]
        static void Main()
        {
            using (ApplicationContext AppContext = new ApplicationContext())
            {                
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);

                AppContext.MainForm = new MainForm();
                Application.Run(AppContext);
            }
        }  

The Main form is a special form. When that form closes the application terminates too.

#### Multiple Document Interface (MDI) applications

In a typical MDI application the main form acts as an MDI child container. Setting the IsMdiContainer boolean property to true turns a form into an MDI child container.

    public bool IsMdiContainer { get; set; }    
    

MDI child forms are displayed as floating forms inside the boundaries of the MDI container client area. The MDI container displays scroll bars automatically when needed.

Setting the MdiParent property

    public Form MdiParent { get; set; }

of a normal form to an MDI container form, turns that form into an MDI child.

    this.IsMdiContainer = true;
    
    ...

    ChildForm child = new ChildForm();
    child.MdiParent = this;
    child.Show();   
    

The IsMdiChild boolean read-only property

    public bool IsMdiChild { get; }
    

returns true if the form is an MDI child.

The MdiChildren array property

    public Form[] MdiChildren { get; }
    

of an MDI container form, returns an array containing its MDI children. Only one of those children could be active at any given time. The ActiveMdiChild property

    public Form ActiveMdiChild { get; }

of an MDI container form returns the currently active child, if any, or null. The MdiChildActivate event

    public event EventHandler MdiChildActivate;

of an MDI container is triggered whenever a child is activated or closed.

    private void MainForm_MdiChildActivate(object sender, EventArgs e)
    {
        if (ActiveMdiChild == null)
            lblActiveChild.Text = "";
        else
            lblActiveChild.Text = ActiveMdiChild.Text;
    }

The LayoutMdi() method

    public void LayoutMdi(MdiLayout value);
    

of an MDI container arranges MDI child forms within the MDI container, according to an MdiLayout enum value

    public enum MdiLayout
    {
        Cascade = 0,
        TileHorizontal = 1,
        TileVertical = 2,
        ArrangeIcons = 3,
    }
    
    ...
    
    this.LayoutMdi(MdiLayout.Cascade);
    

An MDI container almost always provides a menu bar. The new trend is to use the MenuStrip class, introduced by the .Net Framework 2.0, instead of the old MainMenu class, as the main menu of the main form (more on menus later). The Form class provides properties for both though.

    public MenuStrip MainMenuStrip { get; set; }
    public MainMenu Menu { get; set; }  
    
    ...
    
    this.MainMenuStrip = mnuMain;   // the new way
    
    ...
    
    this.MainMenu = mnuMain;        // the old way    
    

Setting the MenuStrip.MdiWindowListItem property

    public ToolStripMenuItem MdiWindowListItem { get; set; }
    

of an MDI container to a ToolStripMenuItem menu item, forces the system to automatically maintain the list of MDI child forms beneath that menu item, giving quick and easy access to the user.

    this.mnuMain.MdiWindowListItem = mnuWindows;
    

The same effect is achieved when using the MainMenu and the MenuItem classes, by setting the MdiList boolean property

    public bool MdiList { get; set; }
    

of a MenuItem to true.

    this.mnuWindows.MdiList = true;    

Here is an example of an MDI container main form that provides a status bar and a menu bar.

    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            /* assign MdiLayout values to menu item tags */
            this.mnuCascade.Tag = MdiLayout.Cascade;
            this.mnuTileHorizontal.Tag = MdiLayout.TileHorizontal;
            this.mnuTileVertical.Tag = MdiLayout.TileVertical;
            this.mnuArrangeIcons.Tag = MdiLayout.ArrangeIcons;
        }

        static int Counter = 0;

        private void mnuExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void mnuNew_Click(object sender, EventArgs e)
        {
            /* create and display a MDI child form */
            ChildForm Form = new ChildForm();
            Form.MdiParent = this;
            Form.Text = "Child " + Counter.ToString();
            Counter++;
            Form.Show();
        }

        /* the MdiChildActivate event is triggered when a MDI child form is activated or closed.   
           The ActiveMdiChild property provides access to the currently activated MDI child, if any */
        private void MainForm_MdiChildActivate(object sender, EventArgs e)
        {
            if (ActiveMdiChild == null)
                lblActiveChild.Text = "";
            else
                lblActiveChild.Text = ActiveMdiChild.Text;
        }

        /* a common event handler for all the menu items that handle the layout of the MDI child forms  */
        private void AnyMdiLayoutMenuItem_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem MI = (ToolStripMenuItem)sender;
            MdiLayout value = (MdiLayout)MI.Tag;
            this.LayoutMdi(value);
        } 
    }

#### Single Document Interface (SDI) applications

In an SDI application there is not a child container. All forms act as independent windows.

An SDI application may confuse the user since any form with its ShowInTaskbar boolean property set to true, the default, appears in the Windows taskbar. (MDI applications do not display their forms in the taskbar even if that ShowInTaskbar is set to true).

    public bool ShowInTaskbar { get; set; }

So, perhaps a first step is to set that ShowInTaskbar to false.

Another problem related to SDI applications is the z-order of the various forms of an application. A large main form may hide any smaller secondary forms behind it when it is focused.

The Form class provides the TopMost boolean property

    public bool TopMost { get; set; }
    

which is not the solution to that z-order problem since a topmost form always overlaps all the other non-topmost forms. The TopMost property, when true, places the form at the top of the z-order of the windows on the desktop. The TopMost property is the proper tool for creating "floating" tool-box forms and find and replace dialogs.

##### The Owner property

The Form class provides the Owner property

        public Form Owner { get; set; }
        

When a form has its Owner assigned, it minimizes and closes along with its Owner. Additionally an owned form is never displayed behind its Owner form.

The AddOwnedForm() and RemoveOwnedForm() methods

    public void AddOwnedForm(Form ownedForm);
    public void RemoveOwnedForm(Form ownedForm);
    

can be used instead of the Owner property. Also the OwnedForms property

    public Form[] OwnedForms { get; }
    

returns an array of the owned forms.

#### Modal forms

A form can be displayed normally as a non-modal form, by using the Show() method.

    public void Show();
    public void Show(IWin32Window owner);
    

A form is displayed as a modal form by using the ShowDialog() method.

    public DialogResult ShowDialog();
    public DialogResult ShowDialog(IWin32Window owner);
    

When a form is displayed modally, its Modal property

    public bool Modal { get; }

returns true.

A modal form prevents access to any other form. Only that modal form and its controls can get user input while the form is displayed. The user has to dismiss that modal form for any other form to get input.

Thus calling the ShowDialog() method has some special effects. The whole application gets into a special mode. The ShowDialog() method does not return until the form is somehow dismissed and so Windows messages are processed by a special message loop inside the ShowDialog() method.

Strictly speaking the ShowDialog() method does not return while the DialogResult property

    public DialogResult DialogResult { get; set; }
    
    public enum DialogResult
    {
        None = 0,
        OK = 1,
        Cancel = 2,
        Abort = 3,
        Retry = 4,
        Ignore = 5,
        Yes = 6,
        No = 7,
    }
    

of that modal form is DialogResult.None. When that DialogResult property is assigned a value other than DialogResult.None, then the ShowDialog() method exits and returns the value of that DialogResult property.

Conveniently enough the System.Windows.Forms.Button control provides a DialogResult property. When a Button, with its DialogResult property set to something other than DialogResult.None, on a modal form is clicked, it passes its DialogResult value to the form's DialogResult forcing the ShowDialog() to return. All this happens automatically. There is no need to write an event handler for the Click event of such a Button. Just set its DialogResult property to a value other than None. It is still valid though to write an event handler for the Click event and that event handler will be normally processed.

When the user closes the Form by clicking the X button at the upper-right corner or using Alt + F4 or double-clicking the system menu at the upper-left corner, the ShowDialog() returns DialogResult.Cancel.

The Form class provides two more convenient properties. The AcceptButton and the CancelButton both of type IButtonControl.

    public IButtonControl AcceptButton { get; set; }
    public IButtonControl CancelButton { get; set; }

    public interface IButtonControl
    {
        DialogResult DialogResult { get; set; }

        void NotifyDefault(bool value);
        void PerformClick();
    }
    

The AcceptButton sets the button on the form which is clicked automatically when the user presses the Space or the Enter key. The CancelButton sets the button that is clicked automatically when the user presses the Escape key.

#### The Form.Close() case

The Form.Close() method is called when a modeless form is closed by the user, by using either the X button at the upper-right corner or the Alt + F4 shortcut or the system menu at the upper-left corner. And of course application code can call Form.Close() on a modeless form as a result of a menu item or a button click.

Calling Close() on a modeless form results in a call to Dispose() method. The form and all of its controls and components are disposed and the form is not usable anymore. Accessing a modeless form after a call to its Close() method results in an exception. This is the norm for normal MDI child forms and SDI forms that displayed non-modally.

For modal forms, according to documentation, the system does not call Form.Close() when the DialogResult property is assigned a value other than None or when the user closes the form by the means described above. Instead the system just hides the form.

The fact is that calling Form.Close(), no matter how, on a modal form does not disposes the form. On a modal form, no call to Form.Dispose() takes place as a consequence of a Form.Close() call. The form can be even re-displayed to the user. For a modal form to be disposed an explicit call to Dispose() is required. The reason behind that behavior is that application code needs to know the result of the ShowDialog() call.

Here is the proper way to display a modal form.

    using (DialogForm Form = new DialogForm())
    {
        DialogResult Res = Form.ShowDialog();
        
        ...
    }

No matter if the form is modal or not, when Close() is called the same sequence of events is triggered.

*   Closing
*   FormClosing
*   Closed
*   FormClosed

Here are the relevant types and definitions.

    public event CancelEventHandler Closing;
    public event EventHandler Closed;
    
    public event FormClosedEventHandler FormClosed;
    public event FormClosingEventHandler FormClosing;

    public delegate void CancelEventHandler(object sender, CancelEventArgs e);

    public class CancelEventArgs : EventArgs
    {
        public CancelEventArgs();
        public CancelEventArgs(bool cancel);

        public bool Cancel { get; set; }
    }

    public delegate void FormClosingEventHandler(object sender, FormClosingEventArgs e);
    
    public class FormClosingEventArgs : CancelEventArgs
    {
        public FormClosingEventArgs(CloseReason closeReason, bool cancel);

        public CloseReason CloseReason { get; }
    }    

    public delegate void FormClosedEventHandler(object sender, FormClosedEventArgs e);
 
    public class FormClosedEventArgs : EventArgs
    {
        public FormClosedEventArgs(CloseReason closeReason);

        public CloseReason CloseReason { get; }
    }
    
    public enum CloseReason
    {
        None = 0,
        WindowsShutDown = 1,
        MdiFormClosing = 2,
        UserClosing = 3,
        TaskManagerClosing = 4,
        FormOwnerClosing = 5,
        ApplicationExitCall = 6,
    }
    

The PropertyGrid hides the Closing and Closed event. They represent the "old way". The new way is the FormClosing and FormClosed events, new to the .Net Framework 2.0. Use those new event with new applications.

The Closing and FormClosing events are called before the form is closed. This give the application code a chance to cancel the closing of the form by just setting the CancelEventArgs.Cancel property to true.

The Closed and FormClosed events are called after the form is closed.

Closing the main form in an MDI application results in triggering the Closing and FormClosing events on all MDI child forms before triggering the same event on the main form. The same stands true for the Closed and FormClosed events too. That is child forms are notified before the MDI container.

#### The power of the visual form inheritance

A Form class may inherit another Form class, just like a non-visual Derived class inherits from a non-visual Base class.

Form inheritance is a powerful tool. It allows to have one or more base form classes providing the common user interface and the common functionality. And then inherit from those base form classes in order to create specializied form classes. A CustomerForm class may inherit from a BaseDataForm class.

The easiest way to apply form inheritance is to create a normal form the usual way, that is Solution Explorer | (right click on) project | Add | Windows Form. Save the project and then

*   close the Form Designer of the new form
*   change the ancestor of the new form, from Form to any available base form class
*   build the project.

Another way is to use Solution Explorer | (right click on) project | Add | New Item | Windows Forms | Inherited Form. This path displays the Inheritance Picker Dialog Box which allows to browse through available base form classes in the same project or any other referenced assembly.

There are some consequences when inheriting a form though. Changes made to the user interface of a base form class, reflect to already created descendants. Although sometimes this requires a build first. Also, controls that must be available to descendant forms, must have their GenerateMember pseudo-property set to true and their Modifiers pseudo-property set, at least, to Protected.

A common practice, when creating the base form, is not to link to form events, but override the relevant method instead. For example instead of writing an event handler for the Load() event, its preferable to override the OnLoad() virtual method. And because some of those methods are called by the Form Designer too, at design time, it is a good practice to distinguise the time by checking the DesignMode boolean property.

    protected override void OnLoad(EventArgs e)
    {
        if (!this.DesignMode)
        {
            ...
        }
        
        base.OnLoad(e);
    }

### Components and Controls

Components and controls are the structural elements of user interface.

Both, components and controls are visible at design time. At design time components reside in the component tray, which occupies an area in the bottom of the Form Designer, where controls are placed on the form being designed.

At runtime only controls are visible. So any element on a form visible at runtime is a control.

Components inherit from Component class. Controls inherit from Control class. Control class inherit from Component class though, so technically speaking, controls are components too.

#### Component class and Control Class

Here is the hierarchy from System.Object to System.Windows.Forms.Control class.

    System.Object
    System.MarshalByRefObject
    System.ComponentModel.Component
    System.Windows.Forms.Control      
        

And here is the public interface of those two fundamental classes.

    public class Component : MarshalByRefObject, IComponent, IDisposable
    {
        public Component();

        public IContainer Container { get; }
        public virtual ISite Site { get; set; }

        public event EventHandler Disposed;

        public void Dispose();
        public override string ToString();
    }
    
    public class Control : Component, IDropTarget, ISynchronizeInvoke, IWin32Window, IBindableComponent, IComponent, IDisposable
    {
        public Control();
        public Control(string text);
        public Control(Control parent, string text);
        public Control(string text, int left, int top, int width, int height);
        public Control(Control parent, string text, int left, int top, int width, int height);

        public AccessibleObject AccessibilityObject { get; }
        public string AccessibleDefaultActionDescription { get; set; }
        public string AccessibleDescription { get; set; }
        public string AccessibleName { get; set; }
        public AccessibleRole AccessibleRole { get; set; }
        public virtual bool AllowDrop { get; set; }
        public virtual AnchorStyles Anchor { get; set; }
        public virtual Point AutoScrollOffset { get; set; }
        public virtual bool AutoSize { get; set; }
        public virtual Color BackColor { get; set; }
        public virtual Image BackgroundImage { get; set; }
        public virtual ImageLayout BackgroundImageLayout { get; set; }
        public virtual BindingContext BindingContext { get; set; }
        public int Bottom { get; }
        public Rectangle Bounds { get; set; }
        public bool CanFocus { get; }
        public bool CanSelect { get; }
        public bool Capture { get; set; }
        public bool CausesValidation { get; set; }
        public static bool CheckForIllegalCrossThreadCalls { get; set; }
        public Rectangle ClientRectangle { get; }
        public Size ClientSize { get; set; }
        public string CompanyName { get; }
        public bool ContainsFocus { get; }
        public virtual ContextMenu ContextMenu { get; set; }
        public virtual ContextMenuStrip ContextMenuStrip { get; set; }
        public Control.ControlCollection Controls { get; }
        public bool Created { get; }
        public virtual Cursor Cursor { get; set; }
        public ControlBindingsCollection DataBindings { get; }
        public static Color DefaultBackColor { get; }
        public static Font DefaultFont { get; }
        public static Color DefaultForeColor { get; }
        public virtual Rectangle DisplayRectangle { get; }
        public bool Disposing { get; }
        public virtual DockStyle Dock { get; set; }
        public bool Enabled { get; set; }
        public virtual bool Focused { get; }
        public virtual Font Font { get; set; }
        public virtual Color ForeColor { get; set; }
        public IntPtr Handle { get; }
        public bool HasChildren { get; }
        public int Height { get; set; }
        public ImeMode ImeMode { get; set; }
        public bool InvokeRequired { get; }
        public bool IsAccessible { get; set; }
        public bool IsDisposed { get; }
        public bool IsHandleCreated { get; }
        public bool IsMirrored { get; }
        public virtual LayoutEngine LayoutEngine { get; }
        public int Left { get; set; }
        public Point Location { get; set; }
        public Padding Margin { get; set; }
        public virtual Size MaximumSize { get; set; }
        public virtual Size MinimumSize { get; set; }
        public static Keys ModifierKeys { get; }
        public static MouseButtons MouseButtons { get; }
        public static Point MousePosition { get; }
        public string Name { get; set; }
        public Padding Padding { get; set; }
        public Control Parent { get; set; }
        public Size PreferredSize { get; }
        public string ProductName { get; }
        public string ProductVersion { get; }
        public bool RecreatingHandle { get; }
        public Region Region { get; set; }
        public int Right { get; }
        public virtual RightToLeft RightToLeft { get; set; }
        public override ISite Site { get; set; }
        public Size Size { get; set; }
        public int TabIndex { get; set; }
        public bool TabStop { get; set; }
        public object Tag { get; set; }
        public virtual string Text { get; set; }
        public int Top { get; set; }
        public Control TopLevelControl { get; }
        public bool UseWaitCursor { get; set; }
        public bool Visible { get; set; }
        public int Width { get; set; }
        public IWindowTarget WindowTarget { get; set; }

        public event EventHandler AutoSizeChanged;
        public event EventHandler BackColorChanged;
        public event EventHandler BackgroundImageChanged;
        public event EventHandler BackgroundImageLayoutChanged;
        public event EventHandler BindingContextChanged;
        public event EventHandler CausesValidationChanged;
        public event UICuesEventHandler ChangeUICues;
        public event EventHandler Click;
        public event EventHandler ClientSizeChanged;
        public event EventHandler ContextMenuChanged;
        public event EventHandler ContextMenuStripChanged;
        public event ControlEventHandler ControlAdded;
        public event ControlEventHandler ControlRemoved;
        public event EventHandler CursorChanged;
        public event EventHandler DockChanged;
        public event EventHandler DoubleClick;
        public event DragEventHandler DragDrop;
        public event DragEventHandler DragEnter;
        public event EventHandler DragLeave;
        public event DragEventHandler DragOver;
        public event EventHandler EnabledChanged;
        public event EventHandler Enter;
        public event EventHandler FontChanged;
        public event EventHandler ForeColorChanged;
        public event GiveFeedbackEventHandler GiveFeedback;
        public event EventHandler GotFocus;
        public event EventHandler HandleCreated;
        public event EventHandler HandleDestroyed;
        public event HelpEventHandler HelpRequested;
        public event EventHandler ImeModeChanged;
        public event InvalidateEventHandler Invalidated;
        public event KeyEventHandler KeyDown;
        public event KeyPressEventHandler KeyPress;
        public event KeyEventHandler KeyUp;
        public event LayoutEventHandler Layout;
        public event EventHandler Leave;
        public event EventHandler LocationChanged;
        public event EventHandler LostFocus;
        public event EventHandler MarginChanged;
        public event EventHandler MouseCaptureChanged;
        public event MouseEventHandler MouseClick;
        public event MouseEventHandler MouseDoubleClick;
        public event MouseEventHandler MouseDown;
        public event EventHandler MouseEnter;
        public event EventHandler MouseHover;
        public event EventHandler MouseLeave;
        public event MouseEventHandler MouseMove;
        public event MouseEventHandler MouseUp;
        public event MouseEventHandler MouseWheel;
        public event EventHandler Move;
        public event EventHandler PaddingChanged;
        public event PaintEventHandler Paint;
        public event EventHandler ParentChanged;
        public event PreviewKeyDownEventHandler PreviewKeyDown;
        public event QueryAccessibilityHelpEventHandler QueryAccessibilityHelp;
        public event QueryContinueDragEventHandler QueryContinueDrag;
        public event EventHandler RegionChanged;
        public event EventHandler Resize;
        public event EventHandler RightToLeftChanged;
        public event EventHandler SizeChanged;
        public event EventHandler StyleChanged;
        public event EventHandler SystemColorsChanged;
        public event EventHandler TabIndexChanged;
        public event EventHandler TabStopChanged;
        public event EventHandler TextChanged;
        public event EventHandler Validated;
        public event CancelEventHandler Validating;
        public event EventHandler VisibleChanged;

        public IAsyncResult BeginInvoke(Delegate method);
        public IAsyncResult BeginInvoke(Delegate method, params object[] args);
        public void BringToFront();
        public bool Contains(Control ctl);
        public void CreateControl();
        public Graphics CreateGraphics();
        public DragDropEffects DoDragDrop(object data, DragDropEffects allowedEffects);
        public void DrawToBitmap(Bitmap bitmap, Rectangle targetBounds);
        public object EndInvoke(IAsyncResult asyncResult);
        public Form FindForm();
        public bool Focus();
        public static Control FromChildHandle(IntPtr handle);
        public static Control FromHandle(IntPtr handle);
        public Control GetChildAtPoint(Point pt);
        public Control GetChildAtPoint(Point pt, GetChildAtPointSkip skipValue);
        public IContainerControl GetContainerControl();
        public Control GetNextControl(Control ctl, bool forward);
        public virtual Size GetPreferredSize(Size proposedSize);
        public void Hide();
        public void Invalidate();
        public void Invalidate(bool invalidateChildren);
        public void Invalidate(Rectangle rc);
        public void Invalidate(Region region);
        public void Invalidate(Rectangle rc, bool invalidateChildren);
        public void Invalidate(Region region, bool invalidateChildren);
        public object Invoke(Delegate method);
        public object Invoke(Delegate method, params object[] args);
        public static bool IsKeyLocked(Keys keyVal);
        public static bool IsMnemonic(char charCode, string text);
        public void PerformLayout();
        public void PerformLayout(Control affectedControl, string affectedProperty);
        public Point PointToClient(Point p);
        public Point PointToScreen(Point p);
        public PreProcessControlState PreProcessControlMessage(ref Message msg);
        public virtual bool PreProcessMessage(ref Message msg);
        public Rectangle RectangleToClient(Rectangle r);
        public Rectangle RectangleToScreen(Rectangle r);
        public virtual void Refresh();
        public virtual void ResetBackColor();
        public void ResetBindings();
        public virtual void ResetCursor();
        public virtual void ResetFont();
        public virtual void ResetForeColor();
        public void ResetImeMode();
        public virtual void ResetRightToLeft();
        public virtual void ResetText();
        public void ResumeLayout();
        public void ResumeLayout(bool performLayout);
        public void Scale(float ratio);
        public void Scale(SizeF factor);
        public void Scale(float dx, float dy);
        public void Select();
        public bool SelectNextControl(Control ctl, bool forward, bool tabStopOnly, bool nested, bool wrap);
        public void SendToBack();
        public void SetBounds(int x, int y, int width, int height);
        public void SetBounds(int x, int y, int width, int height, BoundsSpecified specified);
        public void Show();
        public void SuspendLayout();
        public void Update(); 
    }    

Since all visual at runtime elements inherit from Control class, they all share a common functionality. There are methods, properties and events, common to all controls, regarding features such as the position, the size, the input handling and the appearance of a control.

#### Parentship

A Control can act as a Parent, that is a container, for other controls. This is the reason behind the Control.Parent property. The Parent displays its controls in its client area. If that Parent property is null the control is not displayed at all.

The Control.Controls property, of type Control.ControlCollection, is a collection of the child controls of the control.

        public class ControlCollection : ArrangedElementCollection, IList, ICollection, IEnumerable, ICloneable
        {
            public ControlCollection(Control owner);

            public Control Owner { get; }

            public virtual Control this[int index] { get; }
            public virtual Control this[string key] { get; }

            public virtual void Add(Control value);
            public virtual void AddRange(Control[] controls);
            public virtual void Clear();
            public bool Contains(Control control);
            public virtual bool ContainsKey(string key);
            public Control[] Find(string key, bool searchAllChildren);
            public int GetChildIndex(Control child);
            public virtual int GetChildIndex(Control child, bool throwException);
            public override IEnumerator GetEnumerator();
            public int IndexOf(Control control);
            public virtual int IndexOfKey(string key);
            public virtual void Remove(Control value);
            public void RemoveAt(int index);
            public virtual void RemoveByKey(string key);
            public virtual void SetChildIndex(Control child, int newIndex);
        }

Setting the Parent of a control adds that control into that Controls collection of the Parent. It works the other way too. Adding a control to the Controls collection of another control, assignes the Parent property of the child.

A control's position is relative to its parent.

    button1.Left = 10;  // from the Left of the form
    button1.Top = 10;   // from the Top of the form
    

When a Parent control moves, its child controls move along with it, maintaining their relative coordinates. The ultimate Parent is always a Form object.

#### Screen and client coordinates

The basic measure unit used by Windows Forms for positioning and sizing controls is the device unit, which typically refers to as pixel. A point on screen is defined by a pair of X and Y coordinates. X coordinates increase to the right while Y coordinates increase to the bottom.

Screen coordinates are relative to the top-left corner of the screen, that is the Top-Left of the screen is considered as the 0, 0 point. The position of a top-level window (Form) is defined in screen coordinates.

Client coordinates are relative to the top-left corner of the area of a parent control, that is the Top-Left of a parent control is considered as the 0, 0 point for a child control. The position of a control is defined in client coordinates.

#### The Form class

Here is the hierarchy from System.Windows.Forms.Control to System.Windows.Forms.Form class.

    System.Windows.Forms.Control
    System.Windows.Forms.ScrollableControl
    System.Windows.Forms.ContainerControl
    System.Windows.Forms.Form
    

The ScrollableControl class is the base class for controls that support auto-scrolling behavior.

    public class ScrollableControl : Control, IComponent, IDisposable
    {
        protected const int ScrollStateAutoScrolling = 1;
        protected const int ScrollStateFullDrag = 16;
        protected const int ScrollStateHScrollVisible = 2;
        protected const int ScrollStateUserHasScrolled = 8;
        protected const int ScrollStateVScrollVisible = 4;

        public ScrollableControl();

        public virtual bool AutoScroll { get; set; }
        public Size AutoScrollMargin { get; set; }
        public Size AutoScrollMinSize { get; set; }
        public Point AutoScrollPosition { get; set; }
        protected override CreateParams CreateParams { get; }
        public override Rectangle DisplayRectangle { get; }
        public ScrollableControl.DockPaddingEdges DockPadding { get; }
        public HScrollProperties HorizontalScroll { get; }
        protected bool HScroll { get; set; }
        public VScrollProperties VerticalScroll { get; }
        protected bool VScroll { get; set; }

        public event ScrollEventHandler Scroll;

        protected virtual void AdjustFormScrollbars(bool displayScrollbars);
        protected bool GetScrollState(int bit);
        protected override void OnLayout(LayoutEventArgs levent);
        protected override void OnMouseWheel(MouseEventArgs e);
        protected override void OnPaddingChanged(EventArgs e);
        protected override void OnPaintBackground(PaintEventArgs e);
        protected override void OnRightToLeftChanged(EventArgs e);
        protected virtual void OnScroll(ScrollEventArgs se);
        protected override void OnVisibleChanged(EventArgs e);
        protected override void ScaleControl(SizeF factor, BoundsSpecified specified);
        protected override void ScaleCore(float dx, float dy);
        public void ScrollControlIntoView(Control activeControl);
        protected virtual Point ScrollToControl(Control activeControl);
        public void SetAutoScrollMargin(int x, int y);
        protected void SetDisplayRectLocation(int x, int y);
        protected void SetScrollState(int bit, bool value);
        protected override void WndProc(ref Message m);
    }

    

A ScrollableControl control displays scroll bars when its AutoScroll property is set to true and its size is smaller than the size defined in the AutoScrollMinSize property or a child control falls outside of the visible area of the ScrollableControl control.

A direct ScrollableControl descendant is the Panel class.

The ContainerControl class provides focus-management functionality regarding its child controls.

    public class ContainerControl : ScrollableControl, IContainerControl
    {
        public ContainerControl();

        public Control ActiveControl { get; set; }
        public SizeF AutoScaleDimensions { get; set; }
        protected SizeF AutoScaleFactor { get; }
        public AutoScaleMode AutoScaleMode { get; set; }
        public virtual AutoValidate AutoValidate { get; set; }
        public override BindingContext BindingContext { get; set; }
        protected override bool CanEnableIme { get; }
        protected override CreateParams CreateParams { get; }
        public SizeF CurrentAutoScaleDimensions { get; }
        public Form ParentForm { get; }

        public event EventHandler AutoValidateChanged;

        protected override void AdjustFormScrollbars(bool displayScrollbars);
        protected override void Dispose(bool disposing);
        protected virtual void OnAutoValidateChanged(EventArgs e);
        protected override void OnCreateControl();
        protected override void OnFontChanged(EventArgs e);
        protected override void OnLayout(LayoutEventArgs e);
        protected override void OnParentChanged(EventArgs e);
        public void PerformAutoScale();
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData);
        protected override bool ProcessDialogChar(char charCode);
        protected override bool ProcessDialogKey(Keys keyData);
        protected internal override bool ProcessMnemonic(char charCode);
        protected virtual bool ProcessTabKey(bool forward);
        protected override void Select(bool directed, bool forward);
        protected virtual void UpdateDefaultButton();
        public bool Validate();
        public bool Validate(bool checkAutoValidate);
        public virtual bool ValidateChildren();
        public virtual bool ValidateChildren(ValidationConstraints validationConstraints);
        protected override void WndProc(ref Message m);
    }
    

ContainerControl class provides the ActiveControl property. The ActiveControl, when it is not null, references to the focused child of the Parent control. The ContainerControl captures the TAB key press and moves focus to its next child control.

Here is the public interface of the Form class.

    public class Form : ContainerControl
    {
        public Form();

        public IButtonControl AcceptButton { get; set; }
        public static Form ActiveForm { get; }
        public Form ActiveMdiChild { get; }
        public bool AllowTransparency { get; set; }
        public bool AutoScale { get; set; }
        public virtual Size AutoScaleBaseSize { get; set; }
        public override bool AutoScroll { get; set; }
        public override bool AutoSize { get; set; }
        public AutoSizeMode AutoSizeMode { get; set; }
        public override AutoValidate AutoValidate { get; set; }
        public override Color BackColor { get; set; }
        public IButtonControl CancelButton { get; set; }
        public Size ClientSize { get; set; }
        public bool ControlBox { get; set; }
        public Rectangle DesktopBounds { get; set; }
        public Point DesktopLocation { get; set; }
        public DialogResult DialogResult { get; set; }
        public FormBorderStyle FormBorderStyle { get; set; }
        public bool HelpButton { get; set; }
        public Icon Icon { get; set; }
        public bool IsMdiChild { get; }
        public bool IsMdiContainer { get; set; }
        public bool IsRestrictedWindow { get; }
        public bool KeyPreview { get; set; }
        public Point Location { get; set; }
        public MenuStrip MainMenuStrip { get; set; }
        public Padding Margin { get; set; }
        public bool MaximizeBox { get; set; }
        public override Size MaximumSize { get; set; }
        public Form[] MdiChildren { get; }
        public Form MdiParent { get; set; }
        public MainMenu Menu { get; set; }
        public MainMenu MergedMenu { get; }
        public bool MinimizeBox { get; set; }
        public override Size MinimumSize { get; set; }
        public bool Modal { get; }
        public double Opacity { get; set; }
        public Form[] OwnedForms { get; }
        public Form Owner { get; set; }
        public Rectangle RestoreBounds { get; }
        public virtual bool RightToLeftLayout { get; set; }
        public bool ShowIcon { get; set; }
        public bool ShowInTaskbar { get; set; }
        public Size Size { get; set; }
        public SizeGripStyle SizeGripStyle { get; set; }
        public FormStartPosition StartPosition { get; set; }
        public int TabIndex { get; set; }
        public bool TabStop { get; set; }
        public override string Text { get; set; }
        public bool TopLevel { get; set; }
        public bool TopMost { get; set; }
        public Color TransparencyKey { get; set; }
        public FormWindowState WindowState { get; set; }

        public event EventHandler Activated;
        public event EventHandler AutoSizeChanged;
        public event EventHandler AutoValidateChanged;
        public event EventHandler Closed;
        public event CancelEventHandler Closing;
        public event EventHandler Deactivate;
        public event FormClosedEventHandler FormClosed;
        public event FormClosingEventHandler FormClosing;
        public event CancelEventHandler HelpButtonClicked;
        public event InputLanguageChangedEventHandler InputLanguageChanged;
        public event InputLanguageChangingEventHandler InputLanguageChanging;
        public event EventHandler Load;
        public event EventHandler MarginChanged;
        public event EventHandler MaximizedBoundsChanged;
        public event EventHandler MaximumSizeChanged;
        public event EventHandler MdiChildActivate;
        public event EventHandler MenuComplete;
        public event EventHandler MenuStart;
        public event EventHandler MinimumSizeChanged;
        public event EventHandler ResizeBegin;
        public event EventHandler ResizeEnd;
        public event EventHandler RightToLeftLayoutChanged;
        public event EventHandler Shown;
        public event EventHandler TabIndexChanged;
        public event EventHandler TabStopChanged;

        public void Activate();
        public void AddOwnedForm(Form ownedForm);
        public void Close();
        public static SizeF GetAutoScaleSize(Font font);
        public void LayoutMdi(MdiLayout value);
        public void RemoveOwnedForm(Form ownedForm);
        public void SetDesktopBounds(int x, int y, int width, int height);
        public void SetDesktopLocation(int x, int y);
        public void Show(IWin32Window owner);
        public DialogResult ShowDialog();
        public DialogResult ShowDialog(IWin32Window owner);
        public override string ToString();
        public override bool ValidateChildren();
        public override bool ValidateChildren(ValidationConstraints validationConstraints);
    }
    
    

A Form object can act as a child as long as its TopLevel property is set to false.

    public partial class MainForm : Form
    {
        SecondForm secondForm;

        public MainForm()
        {
            InitializeComponent();

            secondForm = new SecondForm();
            secondForm.TopLevel = false;
            secondForm.Parent = this;
            secondForm.Visible = true;
        }
    }

    ...
    
    public partial class SecondForm : Form
    {
        Button button;
        
        public SecondForm()
        {
            InitializeComponent();

            button = new Button();
            button.Parent = this;
            button.Click += new EventHandler(button_Click);

            button.Left = 10;
            button.Top = 10;
            button.Text = "Click me!";
        }

        void button_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hi there!");
        }
    }    
    
    

In most of the cases a Form is a TopLevel control and has no Parent at all. In that cases form's coordinates are relative to the desktop window.

#### The Form Designer as a code generation tool

The Form Designer can handle either Component objects or Control objects. Components are placed in the so called component tray. Controls are placed on the form surface.

For any new form added to a project the MS Visual Studio IDE generates a new partial Form class spread into two source files: The FormName.cs and the FormName.Designer.cs.

The Form Designer allows to drop controls on a form surface and then arrange and resize those controls by dragging them. The companion Property Grid allows to configure control and component properties and assign event handlers to their events.

All those user actions at design-time simply generate code. That is the Form Designer is a code generation tool. The code the Form Designer generates goes to the FormName.Designer.cs source file, which mainly contains two methods: a protected Dispose() and a private InitializeComponent().

There is also a private components field, of type IContainer.

    partial class MainForm
    {

        private System.ComponentModel.IContainer components = null;
        ...   
    }        

That private components field is a collection of non-Control objects the Form uses. Not all Form's components are placed into that components collection. Only those components that provide a constructor which accepts a single parameter, of type IContainer, go into that collection. That kind of a constructor acts as a sign to the IDE that the component needs a timely disposal. Here is the code the Form Designer generates for such an addition.

    this.timer1 = new System.Windows.Forms.Timer(this.components);

The components private field serves just that requirement: the disposal of any component that needs to be disposed timely. The protected Dispose() method handles that disposal.

    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;
        
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }        
        ...   
    }
    

NOTE: An overriden Dispose() must always call the base.Dispose() as the above method does.

The Control class encapsulates a Windows handle, which is an unmanaged rerource and it needs to be timely released. Thus the Control class is an IDisposable implementor. The Form class is a Control class too and the call to the base.Dispose() is a requirement.

The second method the Form Designer generates, the private InitializeComponent(), is called by the contructor of the Form and contains code generated by the Form Designer. That code reflects any arrangement and configuration done by the programmer at design-time, to the controls and the components of the form.

    private void InitializeComponent()
    {
        this.components = new System.ComponentModel.Container();
        this.label1 = new System.Windows.Forms.Label();
        this.button1 = new System.Windows.Forms.Button();
        this.timer1 = new System.Windows.Forms.Timer(this.components);
        this.SuspendLayout();
        // 
        // label1
        // 
        this.label1.AutoSize = true;
        this.label1.Location = new System.Drawing.Point(41, 78);
        this.label1.Name = "label1";
        this.label1.Size = new System.Drawing.Size(35, 13);
        this.label1.TabIndex = 0;
        this.label1.Text = "label1";
        // 
        // button1
        // 
        this.button1.Location = new System.Drawing.Point(116, 78);
        this.button1.Name = "button1";
        this.button1.Size = new System.Drawing.Size(75, 23);
        this.button1.TabIndex = 1;
        this.button1.Text = "button1";
        this.button1.UseVisualStyleBackColor = true;
        // 
        // MainForm
        // 
        this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(292, 273);
        this.Controls.Add(this.button1);
        this.Controls.Add(this.label1);
        this.Name = "MainForm";
        this.Text = "MainForm";
        this.ResumeLayout(false);
        this.PerformLayout();

    }
 

It is better to let Form Designer handle the code of the InitializeComponent() method. Any user intervention to that code may confuse the Form Designer.

### Control common properties and operations

Since all controls inherit from Control class, there is a functionality common to all controls. And because a control is a visual element, the position and size related functionality falls into that category.

Among other common characteristics is the way a parent control handles the layout of its children, docking and anchoring capabilities and common appearance properties such as text, font, color and mouse cursor.

#### Layout

A parent Control executes a layout logic any time it is resized or any of its child controls is moved or resized. The SuspendLayout() suspends the execution of that logic while the ResumeLayout() signals the end of that suspension. The PerformLayout() method forces the execution of the layout logic and triggers the Layout event.

    public event LayoutEventHandler Layout;

The Form's InitializeComponent() method involves that layout suspension because with all those control additions and arrangements it is just a waste of time and resources. The layout logic is applied at once in the end of the method.

#### The Point, Rectangle and Size structs

The Point, Rectangle and Size structures are used by Control properties and methods related to position and size.

##### Point struct

The System.Drawing.Point struct represents a point in a two-dimensional plane. The X and Y integer properties represent the pair of the x and y coordinates of a point.

    public struct Point
    {
        public static readonly Point Empty;

        public Point(int dw);
        public Point(Size sz);
        public Point(int x, int y);

        public static Point operator -(Point pt, Size sz);
        public static bool operator !=(Point left, Point right);
        public static Point operator +(Point pt, Size sz);
        public static bool operator ==(Point left, Point right);
        public static explicit operator Size(Point p);
        public static implicit operator PointF(Point p);

        public bool IsEmpty { get; }
        public int X { get; set; }
        public int Y { get; set; }

        public static Point Add(Point pt, Size sz);
        public static Point Ceiling(PointF value);
        public override bool Equals(object obj);
        public override int GetHashCode();
        public void Offset(Point p);
        public void Offset(int dx, int dy);
        public static Point Round(PointF value);
        public static Point Subtract(Point pt, Size sz);
        public override string ToString();
        public static Point Truncate(PointF value);
    }
    

##### Rectangle struct

The System.Drawing.Rectangle struct represents a rectangle in in a two-dimensional plane. It defines both the position and the size of a rectangle. The Left, Top, Right and Bottom properties are read-only. The X and Y integer properties define the top-left point. Also the Location property, of type Point, defines that top-left point too. The Width and Height integer properties and the Size property, of type Size, define the size of the rectangle.

    public struct Rectangle
    {
        public static readonly Rectangle Empty;

        public Rectangle(Point location, Size size);
        public Rectangle(int x, int y, int width, int height);

        public static bool operator !=(Rectangle left, Rectangle right);
        public static bool operator ==(Rectangle left, Rectangle right);

        public int Bottom { get; }
        public int Height { get; set; }
        public bool IsEmpty { get; }
        public int Left { get; }
        public Point Location { get; set; }
        public int Right { get; }
        public Size Size { get; set; }
        public int Top { get; }
        public int Width { get; set; }
        public int X { get; set; }
        public int Y { get; set; }

        public static Rectangle Ceiling(RectangleF value);
        public bool Contains(Point pt);
        public bool Contains(Rectangle rect);
        public bool Contains(int x, int y);
        public override bool Equals(object obj);
        public static Rectangle FromLTRB(int left, int top, int right, int bottom);
        public override int GetHashCode();
        public void Inflate(Size size);
        public void Inflate(int width, int height);
        public static Rectangle Inflate(Rectangle rect, int x, int y);
        public void Intersect(Rectangle rect);
        public static Rectangle Intersect(Rectangle a, Rectangle b);
        public bool IntersectsWith(Rectangle rect);
        public void Offset(Point pos);
        public void Offset(int x, int y);
        public static Rectangle Round(RectangleF value);
        public override string ToString();
        public static Rectangle Truncate(RectangleF value);
        public static Rectangle Union(Rectangle a, Rectangle b);
    }
 

##### Size struct

The System.Drawing.Size struct represents the size of rectangle. The Width and Height integer properties are used in defining the dimensions of a rectangle.

    public struct Size
    {
        public static readonly Size Empty;

        public Size(Point pt);
        public Size(int width, int height);

        public static Size operator -(Size sz1, Size sz2);
        public static bool operator !=(Size sz1, Size sz2);
        public static Size operator +(Size sz1, Size sz2);
        public static bool operator ==(Size sz1, Size sz2);
        public static explicit operator Point(Size size);
        public static implicit operator SizeF(Size p);

        public int Height { get; set; }
        public bool IsEmpty { get; }
        public int Width { get; set; }

        public static Size Add(Size sz1, Size sz2);
        public static Size Ceiling(SizeF value);
        public override bool Equals(object obj);
        public override int GetHashCode();
        public static Size Round(SizeF value);
        public static Size Subtract(Size sz1, Size sz2);
        public override string ToString();
        public static Size Truncate(SizeF value);
    }


 

#### Control position and size

The position of a Control is defined by using either the Left and Top integer properties or the Location property, of type Size.

    public int Left { get; set; }
    public int Top { get; set; }
    public Point Location { get; set; }
    
    ...
    
    button1.Left = 10;
    button1.Top = 10;
    
    button2.Location = new Point(10, 50);  // define Left and Top at once
    

The size of a Control is defined by using either the Width and Height integer properties or the Size property, of type Size.

    public int Width { get; set; }
    public int Height { get; set; }    
    public Size Size { get; set; }
    
    ...
    
    button1.Width = 100;
    button1.Height = 35;
    
    button2.Size = new Size(100, 35);  // define Width and Height at once
    

The Form Designer code generator prefers the "at once" way.

    this.button1.Location = new System.Drawing.Point(102, 84);
    this.button1.Name = "button1";
    this.button1.Size = new System.Drawing.Size(75, 23);    
    

Control class provides also the Right and Bottom read-only integer properties.

    public int Right { get; }
    public int Bottom { get; }

Control class provides another way to set position and size of a control at once: The Bounds property, of type Rectangle, and the SetBounds() overloaded method.

    public Rectangle Bounds { get; set; }
    public void SetBounds(int x, int y, int width, int height);
    public void SetBounds(int x, int y, int width, int height, BoundsSpecified specified);   

    ...
    
    button1.Bounds = new Rectangle(10, 10, 100, 35);    // Left, Top, Width, Height
    button2.SetBounds(10, 10, 100, 35);                 // Left, Top, Width, Height
    

##### Size constraints

The MinimumSize and MaximumSize properties, of type Size, act as size contraints for a Control. That constraint is active when the value of that property is greater than the 0, 0 size.

    public virtual Size MinimumSize { get; set; }   
    public virtual Size MaximumSize { get; set; }
    
    ...
    
    button2.MaximumSize = new Size(60, 32);
    button2.Size = new Size(100, 100);    
                             

Control class provides the AutoSize virtual boolean property.

    public virtual bool AutoSize { get; set; }

The AutoSize property is used by some controls, such as the Label and the Form, to indicate whether the control is automatically resized in order to display its entire contents.

##### Client and non-client area

The client area of a control is the area the control occupies on screen, minus any non-client elements of the control. Non-client elements are any borders, bevels, title and caption bars, menus bars and scroll bars. In short, client area is the area available to child (client) controls. Child controls can not be placed in a non-client area of their parent.

The Control class provides properties and methods related to client area.

    public Size ClientSize { get; set; }
    public Rectangle ClientRectangle { get; }

    public Point PointToScreen(Point p);
    public Point PointToClient(Point p);
    
    public Rectangle RectangleToScreen(Rectangle r);
    public Rectangle RectangleToClient(Rectangle r);    
    

The ClientSize property, of type Size, is used to get and set the size of the client area. The ClientRectangle read-only property, of type Rectangle, returns the client rectangle in client coordinates. The PointToScreen() and RectangleToScreen() methods convert from client to screen coordinates, where the PointToClient() and RectangleToClient() convert from screen to client coordinates.

##### The Z-order

Child controls have a z-order in regard to other child controls on the same parent. Control class provides two methods for moving child controls to the top or to the bottom of the z-order.

    public void BringToFront();
    public void SendToBack(); 
    
    ...
    
    private void AnyClick(object sender, EventArgs e)
    {
        (sender as Control).BringToFront();
    }
    

#### Dock and Anchor properties

The Dock property is used to defined automatically the position and the size of a control in regard to its parent. The Dock property is of type DockStyle.

    public enum DockStyle
    {
        None = 0,
        Top = 1,
        Bottom = 2,
        Left = 3,
        Right = 4,
        Fill = 5,
    }

    public virtual DockStyle Dock { get; set; }
    

The DockStyle.None disables docking. The DockStyle.Fill makes the control to occupy all the free space in the client area of its parent. The rest four values force the control to place itself to the corresponding edge of its parent.

When docking is enabled, the Location and Size properties are governed by that setting.

The Anchor property affects the control only when Dock is set to DockStyle.None. The Anchor property forces the control to update its position and size when its parent is resized. The Anchor property is of type AnchorStyles.

    public enum AnchorStyles
    {
        None = 0,
        Top = 1,
        Bottom = 2,
        Left = 4,
        Right = 8,
    }
 
    public virtual AnchorStyles Anchor { get; set; }

AnchorStyles is a "set" property, meaning it can be a combination of the AnchorStyles flags. The default value is Top, Left, which anchors the control to the top and left of its parent.

#### Control common appearance properties

Properties of type Color can be set in many ways.

One way is to use the one of the read only color properties of the System.Drawing.Color struct. The Color struct provides properties with names such as Green, Blue, Cyan, DarkRed etc.

A second way is to use one of the read only color properties of the System.Drawing.SystemColors class. SystemColors class provides properties with names such as ButtonFace, ActiveCaption, ControlText etc. Those colors represent user customizable system colors.

And a third way is to use one of the System.Drawing.Color.FromArgb() method overloads.

    public struct Color
    {
        ...
        
        public static Color FromArgb(int argb);
        public static Color FromArgb(int alpha, Color baseColor);
        public static Color FromArgb(int red, int green, int blue);
        public static Color FromArgb(int alpha, int red, int green, int blue);
        
        ...   
    }        
        

The FromArgb() method constructs a color based on the passed arguments. The A stands for Alpha, that is the transparency. Many controls do not like transparency though. The r, g and b stand for Read, Green and Blue respectively. It turns out that the most easy to use version of the FromArgb() method is the third, the one with the RGB arguments only.

    button1.BackColor = Color.FromArgb(70, 90, 120);
        

##### Colors

The Control.BackColor property, of type Color, gets or sets the background color for the control. The Control.ForeColor property, of type Color, gets or sets the foreground color of the control, that is the color of its text.

##### Text

The Control.Text property, of type System.String, gets or sets the text displayed by the control. Not all controls display text though so that controls just ingore this setting.

##### Font

The Control.Font property, of type Font, gets or sets the font of the text displayed by the control. Here is the Font class.

    public sealed class Font : MarshalByRefObject, ICloneable, ISerializable, IDisposable
    {
        public Font(Font prototype, FontStyle newStyle);
        public Font(FontFamily family, float emSize);
        public Font(string familyName, float emSize);
        public Font(FontFamily family, float emSize, FontStyle style);
        public Font(FontFamily family, float emSize, GraphicsUnit unit);
        public Font(string familyName, float emSize, FontStyle style);
        public Font(string familyName, float emSize, GraphicsUnit unit);
        public Font(FontFamily family, float emSize, FontStyle style, GraphicsUnit unit);
        public Font(string familyName, float emSize, FontStyle style, GraphicsUnit unit);
        public Font(FontFamily family, float emSize, FontStyle style, GraphicsUnit unit, byte gdiCharSet);
        public Font(string familyName, float emSize, FontStyle style, GraphicsUnit unit, byte gdiCharSet);
        public Font(FontFamily family, float emSize, FontStyle style, GraphicsUnit unit, byte gdiCharSet, bool gdiVerticalFont);
        public Font(string familyName, float emSize, FontStyle style, GraphicsUnit unit, byte gdiCharSet, bool gdiVerticalFont);

        public bool Bold { get; }
        public FontFamily FontFamily { get; }
        public byte GdiCharSet { get; }
        public bool GdiVerticalFont { get; }
        public int Height { get; }
        public bool IsSystemFont { get; }
        public bool Italic { get; }
        public string Name { get; }
        public string OriginalFontName { get; }
        public float Size { get; }
        public float SizeInPoints { get; }
        public bool Strikeout { get; }
        public FontStyle Style { get; }
        public string SystemFontName { get; }
        public bool Underline { get; }
        public GraphicsUnit Unit { get; }

        public object Clone();
        public void Dispose();
        public override bool Equals(object obj);
        public static Font FromHdc(IntPtr hdc);
        public static Font FromHfont(IntPtr hfont);
        public static Font FromLogFont(object lf);
        public static Font FromLogFont(object lf, IntPtr hdc);
        public override int GetHashCode();
        public float GetHeight();
        public float GetHeight(float dpi);
        public float GetHeight(Graphics graphics);
        public IntPtr ToHfont();
        public void ToLogFont(object logFont);
        public void ToLogFont(object logFont, Graphics graphics);
        public override string ToString();
    }

The Font class represents system resources and thus implements IDisposable.

Font class properties are read only. That means that it is not possible to change a font after its creation. A new Font instance must be created any time one or more properties of a font must be changed. The Font class provides a number of constructors just for this purpose.

    button1.Font = new Font(button1.Font, FontStyle.Bold | FontStyle.Italic);
    

##### Cursor

The Control.Cursor property, of type Cursor, gets or sets the mouse cursor that is displayed while the mouse pointer is over the control. Here is the Cursor class

    public sealed class Cursor : IDisposable, ISerializable
    {
        public Cursor(IntPtr handle);
        public Cursor(Stream stream);
        public Cursor(string fileName);
        public Cursor(Type type, string resource);

        public static bool operator !=(Cursor left, Cursor right);
        public static bool operator ==(Cursor left, Cursor right);

        public static Rectangle Clip { get; set; }
        public static Cursor Current { get; set; }
        public IntPtr Handle { get; }
        public Point HotSpot { get; }
        public static Point Position { get; set; }
        public Size Size { get; }
        public object Tag { get; set; }

        public IntPtr CopyHandle();
        public void Dispose();
        public void Draw(Graphics g, Rectangle targetRect);
        public void DrawStretched(Graphics g, Rectangle targetRect);
        public override bool Equals(object obj);
        public override int GetHashCode();
        public static void Hide();
        public static void Show();
        public override string ToString();
    }
    

The System.Windows.Forms.Cursors class provides a number of read only properties suitable for setting a Cursor property.

    public sealed class Cursors
    {
        public static Cursor AppStarting { get; }
        public static Cursor Arrow { get; }
        public static Cursor Cross { get; }
        public static Cursor Default { get; }
        public static Cursor Hand { get; }
        public static Cursor Help { get; }
        public static Cursor HSplit { get; }
        public static Cursor IBeam { get; }
        public static Cursor No { get; }
        public static Cursor NoMove2D { get; }
        public static Cursor NoMoveHoriz { get; }
        public static Cursor NoMoveVert { get; }
        public static Cursor PanEast { get; }
        public static Cursor PanNE { get; }
        public static Cursor PanNorth { get; }
        public static Cursor PanNW { get; }
        public static Cursor PanSE { get; }
        public static Cursor PanSouth { get; }
        public static Cursor PanSW { get; }
        public static Cursor PanWest { get; }
        public static Cursor SizeAll { get; }
        public static Cursor SizeNESW { get; }
        public static Cursor SizeNS { get; }
        public static Cursor SizeNWSE { get; }
        public static Cursor SizeWE { get; }
        public static Cursor UpArrow { get; }
        public static Cursor VSplit { get; }
        public static Cursor WaitCursor { get; }
    }
    

#### Ambient properties

The Cursor, Font, ForeColor and BackColor properties of a Control are ambient properties.

An ambient property must be explicitly set. Otherwise it borrows its value from the corresponding property of the Control's Parent or from a system default value.

That ambient mechanism ensures visual consistency. Setting, for example, the BackColor of a Form to Green forces all controls on that form, that do not have their BackColor explicitly defined, to be set to Green.

There are some controls though that ignore that ambient property rule in some special cases. The TextBox, for example, does not borrow its BackColor property value from its Parent. It is initially set according to SystemColors.Window color, which is almost always white.

#### ToolTip component and extender providers

A tool tip is a small "hover box" which is displayed when the mouse cursor is over a user interface element and contains a sort descriptive text regarding that element.

The Control class does not provide a ToolTip property. Instead Windows Forms provide the ToolTip component. When a ToolTip component is placed on a form, at design-time, it extends all other user interface elements on that same form by adding a ToolTip pseudo-property to each of them.

The ToolTip component is a so-called extender provider. An extender provider is a component that provides a property to other components at design-time. That pseudo-property appears as it was a true property in the PropertyGrid. At run-time though that property can not be accessed as it was a true property. Instead the extender provider provides the means for setting and getting the value of that "property".

Here is the declarations.

    public interface IExtenderProvider
    {
        bool CanExtend(object extendee);
    }

    public class ToolTip : Component, IExtenderProvider
    {
        public ToolTip();
        public ToolTip(IContainer cont);

        public bool Active { get; set; }
        public int AutomaticDelay { get; set; }
        public int AutoPopDelay { get; set; }
        public Color BackColor { get; set; }
        public Color ForeColor { get; set; }
        public int InitialDelay { get; set; }
        public bool IsBalloon { get; set; }
        public bool OwnerDraw { get; set; }
        public int ReshowDelay { get; set; }
        public bool ShowAlways { get; set; }
        public bool StripAmpersands { get; set; }
        public object Tag { get; set; }
        public ToolTipIcon ToolTipIcon { get; set; }
        public string ToolTipTitle { get; set; }
        public bool UseAnimation { get; set; }
        public bool UseFading { get; set; }

        public event DrawToolTipEventHandler Draw;
        public event PopupEventHandler Popup;

        public bool CanExtend(object target);
        public string GetToolTip(Control control);
        public void Hide(IWin32Window win);
        public void RemoveAll();
        public void SetToolTip(Control control, string caption);
        public void Show(string text, IWin32Window window);
        public void Show(string text, IWin32Window window, int duration);
        public void Show(string text, IWin32Window window, Point point);
        public void Show(string text, IWin32Window window, int x, int y);
        public void Show(string text, IWin32Window window, Point point, int duration);
        public void Show(string text, IWin32Window window, int x, int y, int duration);
        public override string ToString();
    }
    

The SetToolTip() method, sets the passed string as the tool tip for the control.

     toolTip1.SetToolTip(button1, "Changes the color of the form and the font of this button");
     

#### TabIndex and TabStop properties

The user can move from control to control by pressing the Tab key (or the Shift + Tab combination for backward movement). The so-called "tab order" determines the next control. The TabIndex integer property indicates that tab order and it is Parent related. Controls that have the same Parent, belong to the same "tab-scope".

The TabStop boolean property must be set to true for a control to be part of that tab order. And the Enabled boolean property must be set to true as well. Otherwise the control is excluded from the tab order of its parent.

### Windows messages

Windows, the operating system, communicates by posting messages to applications. Messages posted to an application are placed in a so called message queue owned by the primary thread. The primary thread runs a piece of code, known as the message loop, which handles any message posted to that message queue.

Many of those messages are turned into events in the application, form or control level. The Application.Run() method ignites that message loop processing.

The Application.MessageLoop read-only boolean property indicates whether that primary thread's message loop is started.

Windows messages are represented by integer constants most of which are prefixed by a WM_ which stands for Windows Message. When the WM_QUIT message arrives to that message loop, the message loop exits and the application terminates.

When there are no messages to process the application calls the Application.Idle event.

NOTE: The "About Messages and Message Queues" MSDN topic at http://msdn.microsoft.com/en-us/library/ms644927(VS.85).aspx describes how MS Windows uses messages.

#### Message processing in Windows Forms

A Windows Message conveys a bit of information to the application. The CLR System.Windows.Forms.Message struct represents a windows message.

    public struct Message
    {
        public static bool operator !=(Message a, Message b);
        public static bool operator ==(Message a, Message b);

        public IntPtr HWnd { get; set; }
        public IntPtr LParam { get; set; }
        public int Msg { get; set; }
        public IntPtr Result { get; set; }
        public IntPtr WParam { get; set; }

        public static Message Create(IntPtr hWnd, int msg, IntPtr wparam, IntPtr lparam);
        public override bool Equals(object o);
        public override int GetHashCode();
        public object GetLParam(Type cls);
        public override string ToString();
    }    

    

Those queued messages, as described above, are initially processed by a number of virtual methods at the application, form and control level and many of them are finally turned into events by those methods.

There is a general route all messages, no matter what the type of a message is, go through. Here is the list of those message stations.

*   IMessageFilter.PreFilterMessage()
*   Control.PreProcessMessage()
*   Control.WndProc()
*   Control.DefWndProc()
*   Control.OnNotifyMessage()

##### IMessageFilter

It is possible to intercept a message, at the application level, and stop its further processing before it reaches its target Control. The Application class provides the methods

    public static void AddMessageFilter(IMessageFilter value);
    public static void RemoveMessageFilter(IMessageFilter value);

for installing and removing a, so called, message filter. An application may install as many message filters as they required. A message filter is just a class that implements the System.Windows.Forms.IMessageFilter interface.

    public interface IMessageFilter
    {
        bool PreFilterMessage(ref Message m);
    }
    

Returning true from the PreFilterMessage() method discards the message. Returning false allows the message to continue to the next message filter, if any, or to the target control. Changing a message from inside of a message filter has no effect.

Here is an example

    public partial class MainForm : Form
    {
        const int WM_CHAR = 258;

        public MainForm()
        {
            InitializeComponent();

            new MessageFilter(this);
        }
    }

    /* swallows any WM_CHAR message carrying the character 'a', sent to this application */
    public class MessageFilter : IMessageFilter
    {
        const int WM_CHAR = 258;
        MainForm form;

        public MessageFilter(MainForm Form)
        {
            form = Form;
            Application.AddMessageFilter(this);
        }

        public bool PreFilterMessage(ref Message m)
        {
            if ((m.Msg == WM_CHAR) && ((int)m.WParam == (int)'a'))
                return true;
 
            return false;
        } 
    }

NOTE: Windows message constants, such as the WM_CHAR above, are defined in Windows SDK header files, primarily the WinUser.h and CommCtrl.h. Unfortunately there is no definition of those constants in BCL yet. Here is an article that may help: http://www.codeproject.com/KB/cs/cswindowsmessages.aspx on that matter.

##### Control.PreProcessMessage()

After passing any installed message filter, a message is dispatched to the target control or form. If the message is a WM_KEYDOWN, WM_SYSKEYDOWN, WM_CHAR, or WM_SYSCHAR message, it first goes to the Control.PreProcessMessage() method.

        public virtual bool PreProcessMessage(ref Message msg);
        

A control that overrides the PreProcessMessage() method, may return true to indicate that is has processed the message. Otherwise the it must return the result of base.PreProcessMessage().

##### Control.WndProc()

Regarding how a message reaches its target control there are two categories: posted messages and sent messages.

Posted messages go first to the message queue and then they are handled by the application message loop. The primary tool for posting a message is the PostMessage() WinAPI function.

    [DllImport("user32.dll")] 
    public static extern int PostMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

The PostMessage() function places the message in the message queue and returns immediately. That is the message is processed asynchronously. There can be many messages in that queue waiting for further processing. The application's message loop, strictly speaking the message loop of the primary thread, examines and processes those messages one by one.

Sent messages go directly to the Control.WndProc() method of the target control, by-passing the message queue.

    protected virtual void WndProc(ref Message m);
    

NOTE: The Control.WndProc() method corresponds exactly to a WinAPI Windows Procedure (WindowProc) of a control.

The primary tool for sending messages is the SendMessage() WinAPI function.

    [DllImport("user32.dll")] 
    public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
    

The SendMessage() function sends the message directly to the Control.WndProc() method of the target control and it does not return until the message is processed. That is the message is processed synchronously.

Inevitably queued or non-queued messages reach the Control.WndProc() virtual method. This method is the next station of a message, after getting filtered through the Control.PreProcessMessage() method.

Here is an example that uses the WndProc() to write mouse click coordinates on a form.

    public partial class MainForm : Form
    {
        const int WM_LBUTTONDOWN = 513;


        /// <summary>
        /// Gets the low-order word of Value
        /// </summary>
        static public int LoWord(int Value)
        {
            return (Value & 0xFFFF);
        }
        /// <summary>
        /// Gets the high-order word of Value
        /// </summary>
        static public int HiWord(int Value)
        {
            return ((Value >> 16) & 0xFFFF);
        }


        public MainForm()
        {
            InitializeComponent();
        }

        protected override void WndProc(ref Message m)
        {
        
            /* cracks the WM_LBUTTONDOWN (left mouse button down) message and 
               writes the click coordinates on the form */        
            if (m.Msg == WM_LBUTTONDOWN)
            {
                using (Graphics g = Graphics.FromHwnd(this.Handle))
                {
                    float x = (float)LoWord((int)m.LParam);
                    float y = (float)HiWord((int)m.LParam);
                    string S = string.Format("x = {0}, y = {1}", x, y);
                    g.DrawString(S, this.Font, SystemBrushes.WindowText, x, y);
                }
            }

            base.WndProc(ref m);
        }
    }

##### Control.DefWndProc()

DefWndProc() method is the next station of a message and it provides default message handling for messages not handled elsewhere. Here is the definition

    protected virtual void DefWndProc(ref Message m);

##### Control.OnNotifyMessage()

The last stop of a message is the Control.OnNotifyMessage() method.

    protected virtual void OnNotifyMessage(Message m)
    

Messages reach that method after they have been processed and only if the ControlStyles.EnableNotifyMessage style bit is set for the control with a call to the Control.SetStyle() method.

#### Windows and the NativeWindow class

A Window, from the MS Windows perspective, is an instance of an operating system object uniquely identified by its Handle. A Window Handle is just a number. A Window instance belongs to a so called Window Class. A Window Class has a name and predefined Window Classes have names such as BUTTON, EDIT, COMBOBOX, LISTBOX etc. Window Class names are just strings.

A Window instance may have a style and an extended style, location, dimensions etc. The System.Windows.Forms.CreateParams represents all that information.

    public class CreateParams
    {
        public CreateParams();

        public string Caption { get; set; }
        public string ClassName { get; set; }
        public int ClassStyle { get; set; }
        public int ExStyle { get; set; }
        public int Height { get; set; }
        public object Param { get; set; }
        public IntPtr Parent { get; set; }
        public int Style { get; set; }
        public int Width { get; set; }
        public int X { get; set; }
        public int Y { get; set; }

        public override string ToString();
    }

A Window is created when its handle is created. Sometimes a change to the style of a Window requires a recreation of its handle, that is a recreation of the Window, for those changes to take effect. A Window has a so-called Window procedure, the now familiar WndProc(), where it gets messages posted or sent to it.

The System.Windows.Forms.NativeWindow class represents a Window. The NativeWindow class is actually an encapsulation of a window handle and a window procedure.

    public class NativeWindow : MarshalByRefObject, IWin32Window
    {
        public NativeWindow();

        public IntPtr Handle { get; }

        public void AssignHandle(IntPtr handle);
        public virtual void CreateHandle(CreateParams cp);
        public void DefWndProc(ref Message m);
        public virtual void DestroyHandle();
        public static NativeWindow FromHandle(IntPtr handle);
        protected virtual void OnHandleChange();
        protected virtual void OnThreadException(Exception e);
        public virtual void ReleaseHandle();
        protected virtual void WndProc(ref Message m);
    }

The NativeWindow class can be used in many ways. It can be even attached to an already existing window, using the AssignHandle() and ReleaseHandle() methods.

Here is an example that uses a custom message and the PostMessage() WinAPI function to post that message to a NativeWindow instance.

    public partial class MainForm : Form
    {
        CustomWindow customWindow;         

        public MainForm()
        {
            InitializeComponent();

            customWindow = new CustomWindow(this);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CustomWindow.PostMessage(customWindow.Handle, CustomWindow.UM_TEST, 0, 0);
        }
    }

    /* A NativeWindow descendant which uses the UM_TEST custom message */
    public class CustomWindow : NativeWindow
    {
        static public readonly int WM_USER  = 0x0400;
        static public readonly int UM_TEST = WM_USER + 1;

        [DllImport("user32.dll")]
        public static extern int PostMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        MainForm form;

        public CustomWindow(MainForm Form)
        {
            form = Form;  
            this.CreateHandle(new CreateParams());
        }

        protected override void WndProc(ref Message m)
        {
            if (m.Msg == UM_TEST)
            {
                form.listBox1.Items.Add(DateTime.Now.ToLongTimeString());
            }

            base.WndProc(ref m);
        }
    }
    
    

### User input

User input, such as keyboard and mouse input, follows the path of a message. Windows posts an inpupt message to the application, then that message is prefiltered by any installed message filter, then it is sent to its target control, where it is preprocessed by one or more virtual methods, and finally an event is raised.

For most Windows Forms applications handling such an event is sufficient enough. There are cases though that a special handling of a particular message is required. In that cases the programmer has to override one or more of those virtual methods in order to intercept that particular message.

#### Keyboard input

The keyboard can be seen in two ways: as a set of keys and as a subset of printable character keys. Not all keys generate a printable character.

Pressing a key down, printable or non printable, generates a KeyDown event. Releasing a key, printable or non printable, generates a KeyUp event. If the key being pressed is a printable key, that is a character, a KeyPress event is generated in between.

    public event KeyEventHandler KeyDown;
    public event KeyPressEventHandler KeyPress;
    public event KeyEventHandler KeyUp;

The sequence for pressing the Enter key is KewDown and KeyUp events. The sequence for pressing the A key is KeyDown, KeyPress and KeyUp events.

While the user keeps pressed a key, a series of KeyDown events is generated. If the key is a character key, a series of KeyPress events is generated too. When the user releases the pressed key, just a single KeyUp is generated.

The corresponding messages to those events are WM_KEYDOWN, WM_KEYUP and WM_CHAR.

Windows Forms uses the System.Windows.Forms.Keys enum to represent key information. The Keys enum defines a constant for every key on the keyboard.

    public enum Keys
    {
        Modifiers = -65536,
        None = 0,
        LButton = 1,
        RButton = 2,
        Cancel = 3,
        MButton = 4,
        XButton1 = 5,
        XButton2 = 6,
        Back = 8,
        Tab = 9,
        LineFeed = 10,
        Clear = 12,
        Enter = 13,
        Return = 13,
        ShiftKey = 16,
        ControlKey = 17,
        Menu = 18,
        Pause = 19,
        CapsLock = 20,
        Capital = 20,
        KanaMode = 21,
        HanguelMode = 21,
        HangulMode = 21,
        JunjaMode = 23,
        FinalMode = 24,
        KanjiMode = 25,
        HanjaMode = 25,
        Escape = 27,
        IMEConvert = 28,
        IMENonconvert = 29,
        IMEAceept = 30,
        IMEAccept = 30,
        IMEModeChange = 31,
        Space = 32,
        Prior = 33,
        PageUp = 33,
        Next = 34,
        PageDown = 34,
        End = 35,
        Home = 36,
        Left = 37,
        Up = 38,
        Right = 39,
        Down = 40,
        Select = 41,
        Print = 42,
        Execute = 43,
        PrintScreen = 44,
        Snapshot = 44,
        Insert = 45,
        Delete = 46,
        Help = 47,
        D0 = 48,
        D1 = 49,
        D2 = 50,
        D3 = 51,
        D4 = 52,
        D5 = 53,
        D6 = 54,
        D7 = 55,
        D8 = 56,
        D9 = 57,
        A = 65,
        B = 66,
        C = 67,
        D = 68,
        E = 69,
        F = 70,
        G = 71,
        H = 72,
        I = 73,
        J = 74,
        K = 75,
        L = 76,
        M = 77,
        N = 78,
        O = 79,
        P = 80,
        Q = 81,
        R = 82,
        S = 83,
        T = 84,
        U = 85,
        V = 86,
        W = 87,
        X = 88,
        Y = 89,
        Z = 90,
        LWin = 91,
        RWin = 92,
        Apps = 93,
        Sleep = 95,
        NumPad0 = 96,
        NumPad1 = 97,
        NumPad2 = 98,
        NumPad3 = 99,
        NumPad4 = 100,
        NumPad5 = 101,
        NumPad6 = 102,
        NumPad7 = 103,
        NumPad8 = 104,
        NumPad9 = 105,
        Multiply = 106,
        Add = 107,
        Separator = 108,
        Subtract = 109,
        Decimal = 110,
        Divide = 111,
        F1 = 112,
        F2 = 113,
        F3 = 114,
        F4 = 115,
        F5 = 116,
        F6 = 117,
        F7 = 118,
        F8 = 119,
        F9 = 120,
        F10 = 121,
        F11 = 122,
        F12 = 123,
        F13 = 124,
        F14 = 125,
        F15 = 126,
        F16 = 127,
        F17 = 128,
        F18 = 129,
        F19 = 130,
        F20 = 131,
        F21 = 132,
        F22 = 133,
        F23 = 134,
        F24 = 135,
        NumLock = 144,
        Scroll = 145,
        LShiftKey = 160,
        RShiftKey = 161,
        LControlKey = 162,
        RControlKey = 163,
        LMenu = 164,
        RMenu = 165,
        BrowserBack = 166,
        BrowserForward = 167,
        BrowserRefresh = 168,
        BrowserStop = 169,
        BrowserSearch = 170,
        BrowserFavorites = 171,
        BrowserHome = 172,
        VolumeMute = 173,
        VolumeDown = 174,
        VolumeUp = 175,
        MediaNextTrack = 176,
        MediaPreviousTrack = 177,
        MediaStop = 178,
        MediaPlayPause = 179,
        LaunchMail = 180,
        SelectMedia = 181,
        LaunchApplication1 = 182,
        LaunchApplication2 = 183,
        Oem1 = 186,
        OemSemicolon = 186,
        Oemplus = 187,
        Oemcomma = 188,
        OemMinus = 189,
        OemPeriod = 190,
        OemQuestion = 191,
        Oem2 = 191,
        Oemtilde = 192,
        Oem3 = 192,
        Oem4 = 219,
        OemOpenBrackets = 219,
        OemPipe = 220,
        Oem5 = 220,
        Oem6 = 221,
        OemCloseBrackets = 221,
        Oem7 = 222,
        OemQuotes = 222,
        Oem8 = 223,
        Oem102 = 226,
        OemBackslash = 226,
        ProcessKey = 229,
        Packet = 231,
        Attn = 246,
        Crsel = 247,
        Exsel = 248,
        EraseEof = 249,
        Play = 250,
        Zoom = 251,
        NoName = 252,
        Pa1 = 253,
        OemClear = 254,
        KeyCode = 65535,
        Shift = 65536,
        Control = 131072,
        Alt = 262144,
    }

The KeyDown and KeyUp events are of type KeyEventHandler.

    public delegate void KeyEventHandler(object sender, KeyEventArgs e);
    

The first parameter is the control that raises the event. The second parameter is an instance of the KeyEventArgs class.

    public class KeyEventArgs : EventArgs
    {
        public KeyEventArgs(Keys keyData);

        public virtual bool Alt { get; }
        public bool Control { get; }
        public bool Handled { get; set; }
        public Keys KeyCode { get; }
        public Keys KeyData { get; }
        public int KeyValue { get; }
        public Keys Modifiers { get; }
        public virtual bool Shift { get; }
        public bool SuppressKeyPress { get; set; }
    }
    

The Alt, Control and Shift boolean properties indicate whether any of the Alt, Control and Shift modifier keys are pressed.

The Modifiers property gets a bit-field (a set) indicates the modifier keys being pressed.

The KeyData property gets a bit-field (a set) indicates the modifier keys and the key being pressed.

The KeyCode property indicates the Key being pressed. No modifier keys are used here, just the Key.

The KeyValue property is an integer representation of the KeyCode property.

The SuppressKeyPress property when true prevents the target control from handling the key. Setting this property to true sets the Handled property to true too. The Handled property when true indicates that the event is handled by user code.

Here is an example using the KeyDown event and a form.

    private void MainForm_KeyDown(object sender, KeyEventArgs e)
    {
        label1.Text = string.Format("KeyCode: {0}", e.KeyCode);
        label2.Text = string.Format("KeyData: {0}", e.KeyData);
        label3.Text = string.Format("Modifiers: {0}", e.Modifiers);
        label4.Text = string.Format("KeyValue: {0}", e.KeyValue);
    }
    

The KeyPress event is of type KeyPressEventHandler.

    public delegate void KeyPressEventHandler(object sender, KeyPressEventArgs e);
    

The first parameter is the control that raises the event. The second parameter is an instance of the KeyPressEventArgs class.

    public class KeyPressEventArgs : EventArgs
    {
        public KeyPressEventArgs(char keyChar);

        public bool Handled { get; set; }
        public char KeyChar { get; set; }
    }
    

Setting the Handled property to true, cancels the character press. The KeyChar property is the character being pressed. No modifiers are used here, just the character.

##### Form.KeyPrieview property

The Form class provides the KeyPreview property.

    public bool KeyPreview { get; set; }
    

When the KeyPreview property is true then the Form receives key events before the event is passed to the active control.

#### The KeyCrack helper class

A value of the Keys enum type may contain much information regarding a key pressed. It is useful to have a helper class when working with key information.

    /// <summary>
    /// A static class for cracking Keys enum values
    /// </summary>
    static public class KeyCrack
    {
        /// <summary>
        /// returns true if Alt is in K
        /// </summary>
        static public bool AltIn(Keys K)
        {
            return ((K & Keys.Alt) == Keys.Alt);
        }
        /// <summary>
        /// Returns true if Control is in K
        /// </summary>
        static public bool ControlIn(Keys K)
        {
            return ((K & Keys.Control) == Keys.Control);
        }
        /// <summary>
        /// Returns true if Shift is in K
        /// </summary>
        static public bool ShiftIn(Keys K)
        {
            return ((K & Keys.Shift) == Keys.Shift);
        }
        /// <summary>
        /// Returns the Keys enum constant of K, excluding modifiers, if any
        /// </summary>
        static public Keys CodeOf(Keys K)
        {
            Keys Mask = K & Keys.KeyCode;
            if (!Enum.IsDefined(typeof(Keys), (int)Mask))
                return Keys.None;

            return Mask;
        }
        /// <summary>
        /// Returns true if CodeKey == K excluding any modifiers from K
        /// </summary>
        static public bool CodeIs(Keys K, Keys CodeKey)
        {
            return CodeOf(K) == CodeKey;
        }
        /// <summary>
        /// Returns the modifier constants of K, that is the combination of modifier keys (CTRL, SHIFT, and ALT)
        /// </summary>
        static public Keys ModifiersOf(Keys K)
        {
            return K & Keys.Modifiers;
        }
        /// <summary>
        /// Returns true if K contains modifiers keys
        /// </summary>
        static public bool ContainsModifiers(Keys K)
        {
            return ModifiersOf(K) != Keys.None;
        }
        /// <summary>
        /// Returns true if K contains any non modifier key
        /// </summary>
        static public bool ContainsCode(Keys K)
        {
            return CodeOf(K) != Keys.None;
        }
        /// <summary>
        /// Returns the integer representation of K 
        /// </summary>
        static public int Value(Keys K)
        {
            return (int)(K & Keys.KeyCode);
        }
        /// <summary>
        /// Returns a string representation of K
        /// </summary>
        static public string ToString(Keys K)
        {
            string Res = "";

            if (AltIn(K))
                Res = Res + "Alt, ";

            if (ControlIn(K))
                Res = Res + "Control, ";

            if (ShiftIn(K))
                Res = Res + "Shift, ";

            if (Res.EndsWith(", "))
                Res = Res.Substring(0, Res.Length - 2);

            if (Res != "")
                Res = "(" + Res + ") + " + CodeOf(K).ToString();
            else
                Res = CodeOf(K).ToString();

            return Res;
        }
        /// <summary>
        /// Returns true if K is a Function key (F1 to F24)
        /// </summary>
        static public bool IsFunctionKey(Keys K)
        {
            return ((K & Keys.F1) == Keys.F1)
             || ((K & Keys.F2) == Keys.F2)
             || ((K & Keys.F3) == Keys.F3)
             || ((K & Keys.F4) == Keys.F4)
             || ((K & Keys.F5) == Keys.F5)
             || ((K & Keys.F6) == Keys.F6)
             || ((K & Keys.F7) == Keys.F7)
             || ((K & Keys.F8) == Keys.F8)
             || ((K & Keys.F9) == Keys.F9)
             || ((K & Keys.F10) == Keys.F10)
             || ((K & Keys.F11) == Keys.F11)
             || ((K & Keys.F12) == Keys.F12)
             || ((K & Keys.F13) == Keys.F13)
             || ((K & Keys.F14) == Keys.F14)
             || ((K & Keys.F15) == Keys.F15)
             || ((K & Keys.F16) == Keys.F16)
             || ((K & Keys.F17) == Keys.F17)
             || ((K & Keys.F18) == Keys.F18)
             || ((K & Keys.F19) == Keys.F19)
             || ((K & Keys.F20) == Keys.F20)
             || ((K & Keys.F21) == Keys.F21)
             || ((K & Keys.F22) == Keys.F22)
             || ((K & Keys.F23) == Keys.F23)
             || ((K & Keys.F24) == Keys.F24)
             ;
        }
        /// <summary>
        /// Returns true if K is a control key 
        /// </summary>
        static public bool IsContolKey(Keys K)
        {
            return
                  ((K & Keys.None) == Keys.None)
       || ((K & Keys.Return) == Keys.Return)
       || ((K & Keys.Escape) == Keys.Escape)
       || ((K & Keys.Insert) == Keys.Insert)
       || ((K & Keys.Delete) == Keys.Delete)
       || ((K & Keys.Back) == Keys.Back)
       || ((K & Keys.Home) == Keys.Home)
       || ((K & Keys.End) == Keys.End)
       || ((K & Keys.PageUp) == Keys.PageUp)
       || ((K & Keys.PageDown) == Keys.PageDown)
       || ((K & Keys.Up) == Keys.Up)
       || ((K & Keys.Down) == Keys.Down)
       || ((K & Keys.Left) == Keys.Left)
       || ((K & Keys.Right) == Keys.Right)
       || ((K & Keys.Pause) == Keys.Pause)
               ;

        }

    }

#### Preprocessing keys

As said before the Control.PreProcessMessage() virtual method preprocesses key messages before they reach the WndProc() method and before any event generation, giving a chance to handle special cases.

The PreProcessMessage() method calls one or more virtual methods to handle character keys and physical keys. Those specialized virtual methods may be overriden instead of overriding the general PreProcessMessage() method.

##### KeyDown event preprocessing

Here is the list of those methods regarding key messages in their call sequence.

    protected virtual bool ProcessCmdKey(ref Message msg, Keys keyData);
    protected virtual bool IsInputKey(Keys keyData);
    protected virtual bool ProcessDialogKey(Keys keyData);
    

The ProcessCmdKey() checks to see if the key is menu shortcut or an accelerator. When this method returns true the keystroke is cancelled and the IsInputKey() never called.

The IsInputKey() checks to see if the key is a regular input key or a special key. Returning true, the key gets its route to the KeyDown event. Returning false causes the ProcessDialogKey() to be called.

The ProcessDialogKey() checks to see if the key is is a navigational key such as the arrow keys, the tab and the escape keys. Returning true cancels the keystroke. Returning false generates the KeyDown event.

##### KeyPress event preprocessing

Here is the list of those methods regarding character messages in their call sequence.

    protected virtual bool IsInputChar(char charCode); 
    protected virtual bool ProcessDialogChar(char charCode);

The IsInputChar() checks to see if the character is a normal character. Returning true raises the KeyPress event. Returning false causes the ProcessDialogChar() to be called.

The ProcessDialogChar() checks to see if the character is a mnemonic, such as &OK on a button. Returning true cancels any further processing.

#### Processing keys

After successful preprocessing the key message reaches the WndProc() method. Regarding keyboard input messages the WndProc() calls a set of virtual methods all of which return a boolean value. Returning true to indicates that the keystroke is handled and no further processing is required.

Here is the list of those methods.

    protected internal virtual bool ProcessKeyMessage(ref Message m);
    protected virtual bool ProcessKeyPreview(ref Message m);
    protected virtual bool ProcessKeyEventArgs(ref Message m);
    

The ProcessKeyMessage() processes all key messages after they reach the WndProc() method.

The ProcessKeyPreview() belongs to a parent control and it is called by a child control. Calling this method a child control gives a chance to its parent to prevent any further processing of the message.

The ProcessKeyEventArgs() raises the appropriate KeyDown, KeyUp or KeyPress event.

#### The Keyboard class and the SendKeys class

FCL provides two utility classes regarding keyboard. The System.Windows.Forms.SendKeys is a utility class which provides methods for sending keystrokes to the active window.

    public class SendKeys
    {
        public static void Flush();
        public static void Send(string keys);
        public static void SendWait(string keys);
    }

The Microsoft.VisualBasic.Devices.Keyboard class provides the same functionality as the SendKeys class and some properties providing keyboard information.

    public class Keyboard
    {
        public Keyboard();

        public bool AltKeyDown { get; }
        public bool CapsLock { get; }
        public bool CtrlKeyDown { get; }
        public bool NumLock { get; }
        public bool ScrollLock { get; }
        public bool ShiftKeyDown { get; }

        public void SendKeys(string keys);
        public void SendKeys(string keys, bool wait);
    }

#### Mouse input

Mouse is a pointing device. The mouse pointer, commonly called mouse cursor or just cursor, is just a bitmap that moves across the screen. The shape of the mouse pointer depends on the underlying control and the currently performed operation. That mouse pointer contains a single pixel known as the hot-spot. The system uses that hot-spot in order to identify the actual mouse position on screen.

The System.Windows.Forms.Cursor class represents the mouse cursor and contains useful utility methods and properties. Here is the class definition again.

    public sealed class Cursor : IDisposable, ISerializable
    {
        public Cursor(IntPtr handle);
        public Cursor(Stream stream);
        public Cursor(string fileName);
        public Cursor(Type type, string resource);

        public static bool operator !=(Cursor left, Cursor right);
        public static bool operator ==(Cursor left, Cursor right);

        public static Rectangle Clip { get; set; }
        public static Cursor Current { get; set; }
        public IntPtr Handle { get; }
        public Point HotSpot { get; }
        public static Point Position { get; set; }
        public Size Size { get; }
        public object Tag { get; set; }

        public IntPtr CopyHandle();
        public void Dispose();
        public void Draw(Graphics g, Rectangle targetRect);
        public void DrawStretched(Graphics g, Rectangle targetRect);
        public override bool Equals(object obj);
        public override int GetHashCode();
        public static void Hide();
        public static void Show();
        public override string ToString();
    }

Cursor.Position property indicates the cursor position in screen coordinates while Cursor.HotSpot property indicates cursor position in client coordinates.

    private void MainForm_Click(object sender, EventArgs e)
    {
        string S = string.Format("x = {0}, y = {1} ( x = {2}, y = {3} )",
                                System.Windows.Forms.Cursor.Position.X,
                                System.Windows.Forms.Cursor.Position.Y,
                                System.Windows.Forms.Cursor.Current.HotSpot.X,
                                System.Windows.Forms.Cursor.Current.HotSpot.Y);

        listBox1.Items.Add(S);
    }
    

NOTE: The SystemInformation class provides, among others, many mouse related information.

##### Hit-testing

Hit-testing is the operation that identifies which graphic object or discrete part of that object the mouse is pointing to. Some controls such as the TreeView, the ListView and the DataGridView provide hit-testing build-in capabilities. Those controls usually provide a HitTest() method.

#### Mouse capture

Windows directs mouse input to the control that contains the cursor hot-spot or the control that has captured the mouse input. A control that has captured the mouse input, gets all the mouse input whether or not the cursor hot-spot is within its borders.

Typically a control captures the mouse when the user presses a mouse button on it and releases the mouse capture when the user releases the mouse button.

Also the Control.Capture property

    public bool Capture { get; set; }
    

can be used to get and set the mouse capture for a control. The MouseCaptureChanged event

    public event EventHandler MouseCaptureChanged
    

occurs when the control gains or loses mouse capture.

#### Mouse events

Here is a list with the mouse related events.

    public event EventHandler Click;
    public event EventHandler DoubleClick;

    public event MouseEventHandler MouseClick;
    public event MouseEventHandler MouseDoubleClick;
    
    public event MouseEventHandler MouseDown;
    public event MouseEventHandler MouseMove;
    public event MouseEventHandler MouseUp;
    public event MouseEventHandler MouseWheel;    

    public event EventHandler MouseEnter;
    public event EventHandler MouseHover;
    public event EventHandler MouseLeave;   
    

Some of the above events use the MouseEventHandler delegate which uses a MouseEventArgs instance as its second parameter.

    public delegate void MouseEventHandler(object sender, MouseEventArgs e);

    public class MouseEventArgs : EventArgs
    {
        public MouseEventArgs(MouseButtons button, int clicks, int x, int y, int delta);

        public MouseButtons Button { get; }
        public int Clicks { get; }
        public int Delta { get; }
        public Point Location { get; }
        public int X { get; }
        public int Y { get; }
    }
    
    public enum MouseButtons
    {
        None = 0,
        Left = 1048576,
        Right = 2097152,
        Middle = 4194304,
        XButton1 = 8388608,
        XButton2 = 16777216,
    }
    

The MouseEventArgs.Button property value of the MouseEventArgs parameter depend on the event. Consider the documentation for each specific event.

#### Mouse clicks

Here is the the standard event sequence for a single click.

*   MouseDown event.
*   Click event.
*   MouseClick event.
*   MouseUp event.

Here is the the standard event sequence for a double click.

*   MouseDown event.
*   Click event.
*   MouseClick event.
*   MouseUp event.
*   MouseDown event.
*   DoubleClick event.
*   MouseDoubleClick event.
*   MouseUp event.

The MouseClick and the MouseDoubleClick events introduced in the .Net 2.0 and they actually do the same job as the Click and DoubleClick events.

The same event sequence is generated invariantly for left, middle (wheel) and right mouse buttons.

MouseUp event is raised either when the mouse pointer is over the control or when the mouse pointer is dragged out of the control. No Click or MouseClick is raised when the mouse pointer is dragged out of the control.

#### Mouse move

Here is the the standard event sequence

*   MouseEnter event.
*   MouseMove event.
*   MouseHover event / MouseWheel event.
*   MouseLeave event.

MouseEnter and MouseLeave are raised once, just when the mouse pointer enters and leaves the control.

MouseHover is also raised once, the first time the mouse pointer rests on the control.

MouseMove is raised each time the mouse pointer is moved over the control.

MouseWheel is raised when the mouse wheel moves. The MouseEventArgs.Delta indicates the amount the mouse wheel has been moved.

MouseWheel is raised for the control has the input foucs even if the mouse pointer is not over the control.

### Drag and drop

The Control class fully supports drag and drop operations. A drag and drop operation requires two parts: a drag source and a drop target.

#### The drag source

A drag and drop operation begins when the drag source control calls the DoDragDrop() method.

    public DragDropEffects DoDragDrop(object data, DragDropEffects allowedEffects);
    

The DoDragDrop() method returns a single value from the DragDropEffects enum, which indicates the final effect of the drag and drop operation.

    public enum DragDropEffects
    {
        Scroll = -2147483648,
        All = -2147483645,
        None = 0,
        Copy = 1,
        Move = 2,
        Link = 4,
    } 
    

The second parameter of the DoDragDrop(), the allowedEffects, indicates what kind of drag operations are allowed to the data. The allowedEffects argument could be a combination of the DragDropEffects flags.

The first parameter of the DoDragDrop(), the data, is the data to drag. System.String, System.Drawing.Bitmap or System.Drawing.Imaging.Metafile objects can be passed directly and they are handled automatically. Otherwise that data argument must be an object that implements either the System.Runtime.Serialization.ISerializable or the System.Windows.Forms.IDataObject interface.

    public interface ISerializable
    {
        void GetObjectData(SerializationInfo info, StreamingContext context);
    }
    
    public interface IDataObject
    {
        object GetData(string format);
        object GetData(Type format);
        object GetData(string format, bool autoConvert);
        bool GetDataPresent(string format);
        bool GetDataPresent(Type format);
        bool GetDataPresent(string format, bool autoConvert);
        string[] GetFormats();
        string[] GetFormats(bool autoConvert);
        void SetData(object data);
        void SetData(string format, object data);
        void SetData(Type format, object data);
        void SetData(string format, bool autoConvert, object data);
    }
    

The second case is more handy since there is already a very convenient class that implements the IDataObject interface, the System.Windows.Forms.DataObject class.

    public class DataObject : IDataObject, System.Runtime.InteropServices.ComTypes.IDataObject
    {
        public DataObject();
        public DataObject(object data);
        public DataObject(string format, object data);

        public virtual bool ContainsAudio();
        public virtual bool ContainsFileDropList();
        public virtual bool ContainsImage();
        public virtual bool ContainsText();
        public virtual bool ContainsText(TextDataFormat format);
        public virtual Stream GetAudioStream();
        public virtual object GetData(string format);
        public virtual object GetData(Type format);
        public virtual object GetData(string format, bool autoConvert);
        public virtual bool GetDataPresent(string format);
        public virtual bool GetDataPresent(Type format);
        public virtual bool GetDataPresent(string format, bool autoConvert);
        public virtual StringCollection GetFileDropList();
        public virtual string[] GetFormats();
        public virtual string[] GetFormats(bool autoConvert);
        public virtual Image GetImage();
        public virtual string GetText();
        public virtual string GetText(TextDataFormat format);
        public virtual void SetAudio(byte[] audioBytes);
        public virtual void SetAudio(Stream audioStream);
        public virtual void SetData(object data);
        public virtual void SetData(string format, object data);
        public virtual void SetData(Type format, object data);
        public virtual void SetData(string format, bool autoConvert, object data);
        public virtual void SetFileDropList(StringCollection filePaths);
        public virtual void SetImage(Image image);
        public virtual void SetText(string textData);
        public virtual void SetText(string textData, TextDataFormat format);
    }
    
    

As said before a DataObject instance, strictly speaking an IDataObject instance, can be used as the first parameter, the data, to the DoDragDrop() method. That object must be of either a predefined data format or a custom data format.

When constructing a DataObject using the third constructor of the class

    public DataObject(string format, object data);
    

or when calling DataObject methods that use a string format, such as the SetData() method

    public virtual void SetData(string format, object data);
    

the caller may use one of the static string fields of the DataFormats class.

    public class DataFormats
    {
        public static readonly string Bitmap;
        public static readonly string CommaSeparatedValue;
        public static readonly string Dib;
        public static readonly string Dif;
        public static readonly string EnhancedMetafile;
        public static readonly string FileDrop;
        public static readonly string Html;
        public static readonly string Locale;
        public static readonly string MetafilePict;
        public static readonly string OemText;
        public static readonly string Palette;
        public static readonly string PenData;
        public static readonly string Riff;
        public static readonly string Rtf;
        public static readonly string Serializable;
        public static readonly string StringFormat;
        public static readonly string SymbolicLink;
        public static readonly string Text;
        public static readonly string Tiff;
        public static readonly string UnicodeText;
        public static readonly string WaveAudio;

        public static DataFormats.Format GetFormat(int id);
        public static DataFormats.Format GetFormat(string format);

        public class Format
        {
            public Format(string name, int id);

            public int Id { get; }
            public string Name { get; }
        }
    }
    

The DataFormats class provides a static readonly string field for each predefined data format.

However it is possible to use a custom data format to pass a custom object to the DoDragDrop() method.

    MyCustomData CustomData = new MyCustomData(); 

    DataObject Data = new DataObject();
    Data.SetData("My Custom Data format", CustomData);
    
    if (Source.DoDragDrop(Data, DragDropEffects.Copy) == DragDropEffects.Copy)
        MessageBox.Show("success");    
    

The DoDragDrop() method is usually called from inside a MouseDown event

    private void SourceControl_MouseDown(object sender, MouseEventArgs e)
    {
        /* start the drag and drop operation immediately */
        if (e.Button == MouseButtons.Left)
            SourceControl.DoDragDrop(SourceControl.Text, DragDropEffects.Copy);
    }
    

or from inside a MouseMove event.

    Rectangle dragRect;
     
    private void SourceControl_MouseDown(object sender, MouseEventArgs e)
    {
        dragRect = Rectangle.Empty;
        
        /* defer the beginning of the drag and drop operation to the MouseMove event */
        if (e.Button == MouseButtons.Left)
        {                    
            /* SystemInformation.DragSize returns the Width and Height of a rectangle centered on the hot-spot.           
               dragRect is a rectangle with DragSize dimensions centered on the hot-spot. 
               The hot-spot, the mouse position, has to be moved outside of that dragRect for the DoDragDrop() to be called. */
            Size DragSize = SystemInformation.DragSize;   
            dragRect = new Rectangle(new Point(e.X - (DragSize.Width / 2), e.Y - (DragSize.Height / 2)), DragSize);       
        }           
    }
    
    private void SourceControl_MouseMove(object sender, MouseEventArgs e)
    {
        /* if the mouse position moves outside the dragRect then begin the drag and drop operation */
        if (e.Button == MouseButtons.Left)
            if (dragRect != Rectangle.Empty && !dragRect.Contains(e.X, e.Y))  
                SourceControl.DoDragDrop(SourceControl.Text, DragDropEffects.Copy);    
    }    
    
    private void SourceControl_MouseUp(object sender, MouseEventArgs e)
    {
        dragRect = Rectangle.Empty;
    }
    
    

The drag source control raises two events during a drag and drop operation: the GiveFeedback event and the QueryContinueDrag event.

The GiveFeedback event is raised repeatedly during the operation and gets notifications about the progress of the operation. The GiveFeedback event is of type GiveFeedbackEventHandler delegate. The second parameter of the event is of type GiveFeedbackEventArgs.

    public event GiveFeedbackEventHandler GiveFeedback;

    public delegate void GiveFeedbackEventHandler(object sender, GiveFeedbackEventArgs e);

    public class GiveFeedbackEventArgs : EventArgs
    {
        public GiveFeedbackEventArgs(DragDropEffects effect, bool useDefaultCursors);

        public DragDropEffects Effect { get; }
        public bool UseDefaultCursors { get; set; }
    }

The QueryContinueDrag event is raised repeatedly during the drag and drop operation and allows the drag source to cancel the operation, if needed. QueryContinueDrag event is of type QueryContinueDragEventHandler delegate. The second parameter of the event is of type QueryContinueDragEventArgs.

    public event QueryContinueDragEventHandler QueryContinueDrag;
    
    public delegate void QueryContinueDragEventHandler(object sender, QueryContinueDragEventArgs e);
    
    public class QueryContinueDragEventArgs : EventArgs
    {
        public QueryContinueDragEventArgs(int keyState, bool escapePressed, DragAction action);

        public DragAction Action { get; set; }
        public bool EscapePressed { get; }
        public int KeyState { get; }
    }
    

The QueryContinueDragEventArgs.Action property is of type DragAction enum.

    public enum DragAction
    {
        Continue = 0,
        Drop = 1,
        Cancel = 2,
    }       
    

#### The drop target

During the drag operation the mouse pointer changes shapes to give the user a visual indication whether the underlying control can act as a drop target or not.

For a control to act as a drop target, it must set its AllowDrop boolean property to true.

    Target.AllowDrop = true; 
    

A drop target control gets event notifications when the mouse moves over it, during a drag operation. Here is the event list.

    public event DragEventHandler DragEnter;
    public event DragEventHandler DragOver;
    public event EventHandler DragLeave;    
    public event DragEventHandler DragDrop;  

The DragEnter, DragOver and DragDrop events are of type DragEventHandler delegate. The second parameter of those three events is of type DragEventArgs.

    public delegate void DragEventHandler(object sender, DragEventArgs e);
    
    public class DragEventArgs : EventArgs
    {
        public DragEventArgs(IDataObject data, int keyState, int x, int y, DragDropEffects allowedEffect, DragDropEffects effect);

        public DragDropEffects AllowedEffect { get; }
        public IDataObject Data { get; }
        public DragDropEffects Effect { get; set; }
        public int KeyState { get; }
        public int X { get; }
        public int Y { get; }
    }
    
    
    

During a drag operation the drop target control receives drag events similar to mouse events MouseEnter, MouseLeave and MouseMove.

DragEnter and DragLeave events are raised once, just when the mouse pointer enters and leaves the control.

DragOver is raised each time the mouse pointer is moved over the control.

DragDrop event is raised once, when the user releases the mouse pointer over a drop target.

Inside the DragEnter event handler the drop target control can check the DragEventArgs.AllowedEffect property and respond by choosing the proper effect for itself, by setting the DragEventArgs.Effect property. The control refuses to be a drop target by setting Effect to DragDropEffects.None. The drop target control must also check the data format of the IDragObject, passed as the DragEventArgs.Data property, by calling a version of the IDragObject.GetDataPresent() overload method.

    private void TargetControl_DragEnter(object sender, DragEventArgs e)
    {
        if (e.Data.GetDataPresent(DataFormats.Text))
            if ((e.AllowedEffect & DragDropEffects.Copy) == DragDropEffects.Copy)
                e.Effect = DragDropEffects.Copy;
    }

Setting the DragEventArgs.Effect to a concrete value (Copy, Move or Link) changes the mouse pointer to reflect the effect.

Inside the DragDrop event handler the drop target control handles the dragged data.

    private void TargetControl_DragDrop(object sender, DragEventArgs e)
    {
        if (e.Data.GetDataPresent(DataFormats.Text))
        {
            string S = (string)e.Data.GetData(DataFormats.Text);
            
            ...
        }
    }

#### Drag and drop examples

Here is a drag and drop example with a form and two controls: a TextBox which is the drag source and a ListBox which is the drop target. It illustrates text drag and drop. The source could be the TextBox in this application or any other application which offers drag and drop capabilities, like the MS Word, Acrobat Reader and even the MS Visual Studio itself.

    public partial class SimpleDragDrop : Form
    {
        public SimpleDragDrop()
        {
            InitializeComponent();


            /* The AllowDrop property must be set to true for a control to act as a drag and drop target  */
            lboTarget.AllowDrop = true;
        }


        /* A source control initiates the drag and drop operation by calling the DoDragDrop() method */
        private void txtSource_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                txtSource.DoDragDrop(txtSource.Text, DragDropEffects.Copy);
        }

        /* The DragEnter event occurs on a target control when the mouse pointer enters the control */
        private void lboTarget_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
                e.Effect = DragDropEffects.Copy;
        }

        /* The DragDrop event occurs on a target control when the user releases the mouse button */
        private void lboTarget_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
            {
                string S = (string)e.Data.GetData(DataFormats.Text);
                lboTarget.Items.Add(S);
            }
        }
    }

Here is another drag and drop example. The drag source and the drop target are two ListBox controls. The example demonstrates a custom drag and drop operation by passing an instance of a custom class (Person) from the source control to the target control, using a drag and drop operation.

    public partial class CustomDragDrop : Form
    {
        public CustomDragDrop()
        {
            InitializeComponent();

            /* The AllowDrop property must be set to true for a control to act as a drag and drop target.  */
            lboTarget.AllowDrop = true;

            lboSource.Items.Add(new Person("John Doe", 32));
            lboSource.Items.Add(new Person("Jane Doe", 30));
        }

        /* A source control initiates the drag and drop operation by calling the DoDragDrop() method.
          
           The DoDragDrop() returns the final effect of the operation, so this event handler
           removes the dragged item from the list box on success. 
         
           This event handler uses a DataObject instance to feed the operation. It passes a Person
           instance to the DataObject instance as a custom format, i.e Lessons.Person.
          
           The name of that custom format could be any string as long as it is unique among all
           other formats.
         */
        private void lboSource_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                if (lboSource.SelectedIndex != -1)
                {
                    DataObject DataObj = new DataObject();

                    /* The lboSource.SelectedItem is a Person object */
                    DataObj.SetData("Lessons.Person", lboSource.SelectedItem);

                    /* if DoDragDrop() succeeds then remove the item from the list */
                    if (lboSource.DoDragDrop(DataObj, DragDropEffects.Move) == DragDropEffects.Move)
                        lboSource.Items.Remove(lboSource.SelectedItem);
                }
        }

        /* The DragEnter event occurs on a target control when the mouse pointer enters the control */
        private void lboTarget_DragEnter(object sender, DragEventArgs e)
        {
            /* check to see if the custom format Lessons.Person exists in the DataObject  */
            if (e.Data.GetDataPresent("Lessons.Person"))
                if (e.AllowedEffect == DragDropEffects.Move)
                    e.Effect = DragDropEffects.Move;
        }

        /* The DragDrop event occurs on a target control when the user releases the mouse button.
           If the e.Data DataObject carries a Person object then add it to the source ListBox */
        private void lboTarget_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent("Lessons.Person"))
            {
                Person Person = (Person)e.Data.GetData("Lessons.Person");
                lboTarget.Items.Add(Person);
            }
        }
 
    }


    /* This class is used in the drag and drop operation */
    [Serializable]
    public class Person
    {
        public Person(): this("John Doe", 32)
        {
        }

        public Person(string Name, int Age)
        {
            this.Name = Name;
            this.Age = Age;
        }

        public override string ToString()
        {
            return Name + ", " + Age.ToString();
        }

        public string Name { get; set; }
        public int Age { get; set; }
    }

Running two instances of the application with the above example proves that Person objects can be dragged and dropped even from one application to another.

The third examble demonstrates dragging and dropping files from File Explorer. Actually the drop target, a ListBox, displays just the file name of the file.

    public partial class FileDragDrop : Form
    {
        public FileDragDrop()
        {
            InitializeComponent();

            lboTarget.AllowDrop = true;
        }

        private void lboTarget_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.Link;
        }

        private void lboTarget_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                string[] Files = (string[])e.Data.GetData(DataFormats.FileDrop);
                foreach (string File in Files)
                    lboTarget.Items.Add(File);
            }
        }
    }    
    
    

#### Clipboard class

Windows clipboard is a component of the Windows operating system. Clipboard supports copy and paste data between different parts of the same application or between different application. That data could be text and non-textual information.

Drag and drop operations use that Windows clipboard to move data from one place to another. Windows Forms provide the System.Windows.Forms.Clipboard which represents the clipboard.

    public sealed class Clipboard
    {
        public static void Clear();
        public static bool ContainsAudio();
        public static bool ContainsData(string format);
        public static bool ContainsFileDropList();
        public static bool ContainsImage();
        public static bool ContainsText();
        public static bool ContainsText(TextDataFormat format);
        public static Stream GetAudioStream();
        public static object GetData(string format);
        public static IDataObject GetDataObject();
        public static StringCollection GetFileDropList();
        public static Image GetImage();
        public static string GetText();
        public static string GetText(TextDataFormat format);
        public static void SetAudio(byte[] audioBytes);
        public static void SetAudio(Stream audioStream);
        public static void SetData(string format, object data);
        public static void SetDataObject(object data);
        public static void SetDataObject(object data, bool copy);
        public static void SetDataObject(object data, bool copy, int retryTimes, int retryDelay);
        public static void SetFileDropList(StringCollection filePaths);
        public static void SetImage(Image image);
        public static void SetText(string text);
        public static void SetText(string text, TextDataFormat format);
    }
    
    

NOTE: The Clipboard class can only be used by single thread apartment (STA) threads. By default the Main() method of a Windows Forms application is marked with the STAThreadAttribute attribute so Clipboard class can be used by code the primary thread executes.

Data are placed to the clipboard along with an indication regarding its data format. That way another part of the same application or even another application can recognize and use that data.

A clipboard format is indicated by a string actually. The DataFormats class, described above, provides the list of the predefined formats. Custom formats can also be used.

It is also possible to add the same data more than once, each time indicating a different format. For example the same text can be added as plain text and as RTF text. This can be done by passing a IDataObject containing multiple data formats to the Clipboard.SetDataObject() method.

The SetDataObject() method accepts a data parameter which works in the same way descibed above for the data parameter of the Control.DoDragDrop() method. It could be a System.String, System.Drawing.Bitmap or System.Drawing.Imaging.Metafile object or an object that implements either the System.Runtime.Serialization.ISerializable or the System.Windows.Forms.IDataObject interface.

The SetXXXX() methods place data to the clipboard. The GetXXXX() methods retrieve data from the clipboard. The ContainsXXXX() methods return true when data of a certain data format exist in clipboard.

### Validation and the ErrorProvider component

Windows Forms provides built-in functionality for verifying that data entered to one or more controls, is valid.

The Control class provides the CausesValidation boolean property and the Validating and Validated events for that purpose.

    public bool CausesValidation { get; set; }
    
    public event EventHandler Validated;
    public event CancelEventHandler Validating;    
    

Also the ContainerControl class provides the AutoValidate property

    public virtual AutoValidate AutoValidate { get; set; }    
    

of type AutoValidate enum.

    public enum AutoValidate
    {
        Inherit = -1,
        Disable = 0,
        EnablePreventFocusChange = 1,
        EnableAllowFocusChange = 2,
    }
    

Validation is related to focus management. A focused control, with its CausesValidation set to true, is validated when it loses focus because another control, with its own CausesValidation set to true, receives the focus. When that kind of focus change occurs the Validating event of the first control is triggered.

Also for this validation to happen the AutoValidate property of the parent ContainerControl, usually a Form or a UserControl, must be set to either AutoValidate.EnablePreventFocusChange or to AutoValidate.EnableAllowFocusChange.

The control fails to pass the validation check successfuly when the Validating event handler sets, for some reason, the CancelEventArgs.Cancel boolean property to true. Besides that, if the parent ContainerControl has its AutoValidate property set to AutoValidate.EnablePreventFocusChange the focus will not change.

If the control passes the validation check successfuly then the Validated event is triggered.

By default CausesValidation is true and AutoValidate is AutoValidate.EnablePreventFocusChange. This means that the programmer has just to write the Validating event handler.

Having a control blocking the focus infinitely is meaningless, unless some visual clue is provided to the user of what went wrong. This is a task for the ErrorProvider component.

    public class ErrorProvider : Component, IExtenderProvider, ISupportInitialize
    {
        public ErrorProvider();
        public ErrorProvider(ContainerControl parentControl);
        public ErrorProvider(IContainer container);

        public int BlinkRate { get; set; }
        public ErrorBlinkStyle BlinkStyle { get; set; }
        public ContainerControl ContainerControl { get; set; }
        public string DataMember { get; set; }
        public object DataSource { get; set; }
        public Icon Icon { get; set; }
        public virtual bool RightToLeft { get; set; }
        public override ISite Site { set; }
        public object Tag { get; set; }

        public event EventHandler RightToLeftChanged;

        public void BindToDataAndErrors(object newDataSource, string newDataMember);
        public bool CanExtend(object extendee);
        public void Clear();
        protected override void Dispose(bool disposing);
        public string GetError(Control control);
        public ErrorIconAlignment GetIconAlignment(Control control);
        public int GetIconPadding(Control control);
        protected virtual void OnRightToLeftChanged(EventArgs e);
        public void SetError(Control control, string value);
        public void SetIconAlignment(Control control, ErrorIconAlignment value);
        public void SetIconPadding(Control control, int padding);
        public void UpdateBinding();
    }

The ErrorProvider displays a flashing icon next to a non-validated control. When the mouse is over that icon causes the icon to display a ToolTip with a descriptive error message.

There are some ways to use the ErrorProvider. One is to call its SetError() method to indicate what went wrong and where. This is usually done from inside a Validating event handler.

    private void textBox1_Validating(object sender, CancelEventArgs e)
    {
        TextBox textBox = sender as TextBox;
        
        if (textBox != null)
        {
            int Res = 0;
            if (!int.TryParse(textBox.Text, out Res))
            {
                errorProvider1.SetError(textBox, "Invalid integer value");
                e.Cancel = true;
            }
        }            
    }
    

Another way is to use the DataSource and maybe the DataMember properties of the ErrorProvider and the error related properties of a DataRow object, when data bound controls are used.

    errorProvider1.DataSource = table;
    
    ...
    
    private void btnSave_Click(object sender, EventArgs e)
    {
        DataRow Row = table.Rows[0];

        if ((Row["Code"] == DBNull.Value) || ("" == (string)(Row["Code"])))
        {
            Row.RowError = "Invalid Code";
            Row.SetColumnError("Code", "Invalid Code");
        }
 
        ...
        
        if (!table.HasErrors)
            this.DialogResult = DialogResult.OK;
        else
            MessageBox.Show("Please, correct any error");
    }

To clear the errors use the ErrorProvider.SetError() passing an empty string

    private void AnyControl_Validated(object sender, EventArgs e)
    {
        errorProvider1.SetError((Control)sender, "");
    }    
    

or the DataRow.ClearErrors() method.

### Windows Forms built-in controls and components

Windows Forms provides a standard set of controls and components for building rich user interface. Buttons, text boxes, list anc combo boxes and more complex ones such as the ListView, TreeView and the TabControl.

There are also commercial control libraries available by third party vendors and many freeware controls and libraries written by the .Net developer community.

see also:

*   [http://www.codeproject.com](   http://www.codeproject.com)
*   [http://www.devexpress.com/](http://www.devexpress.com/)
*   [http://www.infragistics.com/](http://www.infragistics.com/)

#### Buttons

There are three buttons: the Button, RadioButton and CheckBox. They all inherit from the System.Windows.Forms.ButtonBase class.

    public abstract class ButtonBase : Control
    {
        public bool AutoEllipsis { get; set; }
        public override bool AutoSize { get; set; }
        public override Color BackColor { get; set; }
        public FlatButtonAppearance FlatAppearance { get; }
        public FlatStyle FlatStyle { get; set; }
        public Image Image { get; set; }
        public ContentAlignment ImageAlign { get; set; }
        public int ImageIndex { get; set; }
        public string ImageKey { get; set; }
        public ImageList ImageList { get; set; }
        public ImeMode ImeMode { get; set; }
        public override string Text { get; set; }
        public virtual ContentAlignment TextAlign { get; set; }
        public TextImageRelation TextImageRelation { get; set; }
        public bool UseCompatibleTextRendering { get; set; }
        public bool UseMnemonic { get; set; }
        public bool UseVisualStyleBackColor { get; set; }

        public event EventHandler AutoSizeChanged;
        public event EventHandler ImeModeChanged;

        public override Size GetPreferredSize(Size proposedSize);

        public class ButtonBaseAccessibleObject : Control.ControlAccessibleObject
        {
            public ButtonBaseAccessibleObject(Control owner);

            public override AccessibleStates State { get; }

            public override void DoDefaultAction();
        }
    }
    

The ButtonBase class provides a set of properties that affect the visual aspect of the button such as the FlatStyle, FlatAppearance, ImageList and ImageIndex etc.

##### Button

A classic button control programmers use all the time as a command button.

    public class Button : ButtonBase, IButtonControl
    {
        public Button();

        public AutoSizeMode AutoSizeMode { get; set; }
        public virtual DialogResult DialogResult { get; set; }

        public event EventHandler DoubleClick;
        public event MouseEventHandler MouseDoubleClick;

        public virtual void NotifyDefault(bool value);
        public void PerformClick();
        public override string ToString();
    }
    
    

##### CheckBox

A classic check box with three-state capability.

    public class CheckBox : ButtonBase
    {
        public CheckBox();

        public Appearance Appearance { get; set; }
        public bool AutoCheck { get; set; }
        public ContentAlignment CheckAlign { get; set; }
        public bool Checked { get; set; }
        public CheckState CheckState { get; set; }
        public override ContentAlignment TextAlign { get; set; }
        public bool ThreeState { get; set; }
        
        ... 
        
        public event EventHandler CheckedChanged;
        public event EventHandler CheckStateChanged; 
        
        ...       
    } 

##### RadioButton

A classic radio button, also known as option button.

    public class RadioButton : ButtonBase
    {
        public RadioButton();

        public Appearance Appearance { get; set; }
        public bool AutoCheck { get; set; }
        public ContentAlignment CheckAlign { get; set; }
        public bool Checked { get; set; }
        public bool TabStop { get; set; }
        public override ContentAlignment TextAlign { get; set; }

        ...
        
        public event EventHandler CheckedChanged;

        public void PerformClick();
        
        ...
 
    }

Radio buttons work in groups. All radio buttons on the same parent act as a group. When AutoCheck is true, clicking on a radio button selects that button and de-selects any other radio button on the same parent.

#### TextBox

Inherits from the TextBoxBase class.

    public abstract class TextBoxBase : Control
    {
        public bool AcceptsTab { get; set; }
        public override bool AutoSize { get; set; }
        public override Color BackColor { get; set; }
        public override Image BackgroundImage { get; set; }
        public override ImageLayout BackgroundImageLayout { get; set; }
        public BorderStyle BorderStyle { get; set; }
        public bool CanUndo { get; }
        public override Color ForeColor { get; set; }
        public bool HideSelection { get; set; }
        public string[] Lines { get; set; }
        public virtual int MaxLength { get; set; }
        public bool Modified { get; set; }
        public virtual bool Multiline { get; set; }
        public Padding Padding { get; set; }
        public int PreferredHeight { get; }
        public bool ReadOnly { get; set; }
        public virtual string SelectedText { get; set; }
        public virtual int SelectionLength { get; set; }
        public int SelectionStart { get; set; }
        public virtual bool ShortcutsEnabled { get; set; }
        public override string Text { get; set; }
        public virtual int TextLength { get; }
        public bool WordWrap { get; set; }

        public event EventHandler AcceptsTabChanged;
        public event EventHandler AutoSizeChanged;
        public event EventHandler BackgroundImageChanged;
        public event EventHandler BackgroundImageLayoutChanged;
        public event EventHandler BorderStyleChanged;
        public event EventHandler Click;
        public event EventHandler HideSelectionChanged;
        public event EventHandler ModifiedChanged;
        public event MouseEventHandler MouseClick;
        public event EventHandler MultilineChanged;
        public event EventHandler PaddingChanged;
        public event PaintEventHandler Paint;
        public event EventHandler ReadOnlyChanged;

        public void AppendText(string text);
        public void Clear();
        public void ClearUndo();
        public void Copy();
        public void Cut();
        public void DeselectAll();
        public virtual char GetCharFromPosition(Point pt);
        public virtual int GetCharIndexFromPosition(Point pt);
        public int GetFirstCharIndexFromLine(int lineNumber);
        public int GetFirstCharIndexOfCurrentLine();
        public virtual int GetLineFromCharIndex(int index);
        public virtual Point GetPositionFromCharIndex(int index);
        public void Paste();
        public void ScrollToCaret();
        public void Select(int start, int length);
        public void SelectAll();
        public override string ToString();
        public void Undo();
    }

    public class TextBox : TextBoxBase
    {
        public TextBox();

        public bool AcceptsReturn { get; set; }
        public AutoCompleteStringCollection AutoCompleteCustomSource { get; set; }
        public AutoCompleteMode AutoCompleteMode { get; set; }
        public AutoCompleteSource AutoCompleteSource { get; set; }
        public CharacterCasing CharacterCasing { get; set; }
        public override bool Multiline { get; set; }
        public char PasswordChar { get; set; }
        public ScrollBars ScrollBars { get; set; }
        public override string Text { get; set; }
        public HorizontalAlignment TextAlign { get; set; }
        public bool UseSystemPasswordChar { get; set; }

        public event EventHandler TextAlignChanged;

        public void Paste(string text);
    }
    

TextBox is a classic text box. Can be either single-line or multi-line. When Multiline boolean property is set to true, then Environment.NewLine is considered as the new line mark. Some properties, such as ScrollBars and WordWrap work only when the text box is a multi-line one.

TextBox provides text selection functionality through the SelectedText, SelectionLength and SelectionStart properties and the Select() and SelectAll() methods.

Also the TextBox provides auto-completion functionality through the AutoCompleteMode, AutoCompleteCustomSource and AutoCompleteSource properties.

The TextBox has a 64K character capacity limit.

#### MaskedTextBox

    public class MaskedTextBox : TextBoxBase
    {
        public MaskedTextBox();
        public MaskedTextBox(MaskedTextProvider maskedTextProvider);
        public MaskedTextBox(string mask);

        public bool AcceptsTab { get; set; }
        public bool AllowPromptAsInput { get; set; }
        public bool AsciiOnly { get; set; }
        public bool BeepOnError { get; set; }
        public bool CanUndo { get; }
        public CultureInfo Culture { get; set; }
        public MaskFormat CutCopyMaskFormat { get; set; }
        public IFormatProvider FormatProvider { get; set; }
        public bool HidePromptOnLeave { get; set; }
        public InsertKeyMode InsertKeyMode { get; set; }
        public bool IsOverwriteMode { get; }
        public string[] Lines { get; set; }
        public string Mask { get; set; }
        public bool MaskCompleted { get; }
        public MaskedTextProvider MaskedTextProvider { get; }
        public bool MaskFull { get; }
        public override int MaxLength { get; set; }
        public override bool Multiline { get; set; }
        public char PasswordChar { get; set; }
        public char PromptChar { get; set; }
        public bool ReadOnly { get; set; }
        public bool RejectInputOnFirstFailure { get; set; }
        public bool ResetOnPrompt { get; set; }
        public bool ResetOnSpace { get; set; }
        public override string SelectedText { get; set; }
        public bool SkipLiterals { get; set; }
        public override string Text { get; set; }
        public HorizontalAlignment TextAlign { get; set; }
        public override int TextLength { get; }
        public MaskFormat TextMaskFormat { get; set; }
        public bool UseSystemPasswordChar { get; set; }
        public Type ValidatingType { get; set; }
        public bool WordWrap { get; set; }

        ...

        public void ClearUndo();
        public override char GetCharFromPosition(Point pt);
        public override int GetCharIndexFromPosition(Point pt);
        public int GetFirstCharIndexFromLine(int lineNumber);
        public int GetFirstCharIndexOfCurrentLine();
        public override int GetLineFromCharIndex(int index);
        public override Point GetPositionFromCharIndex(int index);
        public void ScrollToCaret();
        public override string ToString();
        public void Undo();
        public object ValidateText();
    }

MaskedTextBox is TextBox with a Mask string property. The mask indicates to the user which and how many characters are permitted and in what position. Characters that, according to mask, are not valid are just rejected. In short MaskedTextBox validates characters while they are entered to the control.

The design time support of the Mask property provides a dialog box for selecting or editing masks.

#### RichTextBox

    public class RichTextBox : TextBoxBase
    {
        public RichTextBox();

        public override bool AllowDrop { get; set; }
        public override bool AutoSize { get; set; }
        public bool AutoWordSelection { get; set; }
        public override Image BackgroundImage { get; set; }
        public override ImageLayout BackgroundImageLayout { get; set; }
        public int BulletIndent { get; set; }
        public bool CanRedo { get; }
        public bool DetectUrls { get; set; }
        public bool EnableAutoDragDrop { get; set; }
        public override Font Font { get; set; }
        public override Color ForeColor { get; set; }
        public RichTextBoxLanguageOptions LanguageOption { get; set; }
        public override int MaxLength { get; set; }
        public override bool Multiline { get; set; }
        public string RedoActionName { get; }
        public bool RichTextShortcutsEnabled { get; set; }
        public int RightMargin { get; set; }
        public string Rtf { get; set; }
        public RichTextBoxScrollBars ScrollBars { get; set; }
        public string SelectedRtf { get; set; }
        public override string SelectedText { get; set; }
        public HorizontalAlignment SelectionAlignment { get; set; }
        public Color SelectionBackColor { get; set; }
        public bool SelectionBullet { get; set; }
        public int SelectionCharOffset { get; set; }
        public Color SelectionColor { get; set; }
        public Font SelectionFont { get; set; }
        public int SelectionHangingIndent { get; set; }
        public int SelectionIndent { get; set; }
        public override int SelectionLength { get; set; }
        public bool SelectionProtected { get; set; }
        public int SelectionRightIndent { get; set; }
        public int[] SelectionTabs { get; set; }
        public RichTextBoxSelectionTypes SelectionType { get; }
        public bool ShowSelectionMargin { get; set; }
        public override string Text { get; set; }
        public override int TextLength { get; }
        public string UndoActionName { get; }
        public float ZoomFactor { get; set; }

        public event EventHandler BackgroundImageChanged;
        public event EventHandler BackgroundImageLayoutChanged;
        public event ContentsResizedEventHandler ContentsResized;
        public event DragEventHandler DragDrop;
        public event DragEventHandler DragEnter;
        public event EventHandler DragLeave;
        public event DragEventHandler DragOver;
        public event GiveFeedbackEventHandler GiveFeedback;
        public event EventHandler HScroll;
        public event EventHandler ImeChange;
        public event LinkClickedEventHandler LinkClicked;
        public event EventHandler Protected;
        public event QueryContinueDragEventHandler QueryContinueDrag;
        public event EventHandler SelectionChanged;
        public event EventHandler VScroll;

        public bool CanPaste(DataFormats.Format clipFormat);
        public void DrawToBitmap(Bitmap bitmap, Rectangle targetBounds);
        public int Find(char[] characterSet);
        public int Find(string str);
        public int Find(char[] characterSet, int start);
        public int Find(string str, RichTextBoxFinds options);
        public int Find(char[] characterSet, int start, int end);
        public int Find(string str, int start, RichTextBoxFinds options);
        public int Find(string str, int start, int end, RichTextBoxFinds options);
        public override int GetCharIndexFromPosition(Point pt);
        public override int GetLineFromCharIndex(int index);
        public override Point GetPositionFromCharIndex(int index);
        public void LoadFile(string path);
        public void LoadFile(Stream data, RichTextBoxStreamType fileType);
        public void LoadFile(string path, RichTextBoxStreamType fileType);
        public void Paste(DataFormats.Format clipFormat);
        public void Redo();
        public void SaveFile(string path);
        public void SaveFile(Stream data, RichTextBoxStreamType fileType);
        public void SaveFile(string path, RichTextBoxStreamType fileType);
    }
    

RichTextBox is a multi-line text box that can display and edit RTF text, that is formatted text with bold, italic, colors etc.

The SelectionFont and the SelectionColor are the key properties. The formatting is applied any selected text or to new text entered after the change.

    void AnyRichTextBoxSettingChanged(object sender, EventArgs e)
    {

        FontStyle FS = FontStyle.Regular;

        if (chBold.Checked)
            FS = FS | FontStyle.Bold;

        if (chItalic.Checked)
            FS = FS | FontStyle.Italic;

        if (chUnderline.Checked)
            FS = FS | FontStyle.Underline;

        Editor.SelectionFont = new Font(Editor.SelectionFont.FontFamily.Name, Convert.ToSingle(edtFontSize.Value), FS);
        Editor.SelectionColor = Color.FromName(cboFontColor.Text);
    }
    

The LoadFile() and SaveFile() methods can be used to load and save the content of a RichTextBox to an .rtf file.

The RichTextBox has not any character capacity limit.

see also:

*   [http://en.wikipedia.org/wiki/Rich_Text_Format](   http://en.wikipedia.org/wiki/Rich_Text_Format)

#### List controls: ComboBox, ListBox and CheckedListBox

The base class is Windows.Forms.ListControl.

    public abstract class ListControl : Control
    {
        public object DataSource { get; set; }
        public string DisplayMember { get; set; }
        public IFormatProvider FormatInfo { get; set; }
        public string FormatString { get; set; }
        public bool FormattingEnabled { get; set; }
        public abstract int SelectedIndex { get; set; }
        public object SelectedValue { get; set; }
        public string ValueMember { get; set; }

        ...
        public event EventHandler SelectedValueChanged;
        public event EventHandler ValueMemberChanged;

        public string GetItemText(object item);
    }
    
    

##### ComboBox

    public class ComboBox : ListControl
    {
        public ComboBox();

        public AutoCompleteStringCollection AutoCompleteCustomSource { get; set; }
        public AutoCompleteMode AutoCompleteMode { get; set; }
        public AutoCompleteSource AutoCompleteSource { get; set; }
        public override Color BackColor { get; set; }
        public override Image BackgroundImage { get; set; }
        public override ImageLayout BackgroundImageLayout { get; set; }
        public object DataSource { get; set; }
        public DrawMode DrawMode { get; set; }
        public int DropDownHeight { get; set; }
        public ComboBoxStyle DropDownStyle { get; set; }
        public int DropDownWidth { get; set; }
        public bool DroppedDown { get; set; }
        public FlatStyle FlatStyle { get; set; }
        public override bool Focused { get; }
        public override Color ForeColor { get; set; }
        public bool IntegralHeight { get; set; }
        public int ItemHeight { get; set; }
        public ComboBox.ObjectCollection Items { get; }
        public int MaxDropDownItems { get; set; }
        public override Size MaximumSize { get; set; }
        public int MaxLength { get; set; }
        public override Size MinimumSize { get; set; }
        public Padding Padding { get; set; }
        public int PreferredHeight { get; }
        public override int SelectedIndex { get; set; }
        public object SelectedItem { get; set; }
        public string SelectedText { get; set; }
        public int SelectionLength { get; set; }
        public int SelectionStart { get; set; }
        public bool Sorted { get; set; }
        public override string Text { get; set; }

        ...
        
        public event EventHandler DoubleClick;
        public event EventHandler DropDown;
        public event EventHandler DropDownClosed;
        public event EventHandler SelectedIndexChanged;
        public event EventHandler SelectionChangeCommitted;

        ...

        public void BeginUpdate();
        public void EndUpdate();
        public int FindString(string s);
        public int FindString(string s, int startIndex);
        public int FindStringExact(string s);
        public int FindStringExact(string s, int startIndex);
        public int GetItemHeight(int index);
        public override void ResetText();
        public void Select(int start, int length);
        public void SelectAll();
        public override string ToString();

        ...
    }

ComboBox represents a drop-down list of choices. The list is a list of objects, so practically an item can be of any type. The key properties are the SelectedIndex and the SelectedItem. The Text property returns the text of the selected item, if any.

Also the ComboBox provides auto-completion functionality through the AutoCompleteMode, AutoCompleteCustomSource and AutoCompleteSource properties.

##### ListBox

    public class ListBox : ListControl
    {
        ...

        public ListBox();

        public override Color BackColor { get; set; }
        public override Image BackgroundImage { get; set; }
        public override ImageLayout BackgroundImageLayout { get; set; }
        public BorderStyle BorderStyle { get; set; }
        public int ColumnWidth { get; set; }
        public ListBox.IntegerCollection CustomTabOffsets { get; }
        public virtual DrawMode DrawMode { get; set; }
        public override Font Font { get; set; }
        public override Color ForeColor { get; set; }
        public int HorizontalExtent { get; set; }
        public bool HorizontalScrollbar { get; set; }
        public bool IntegralHeight { get; set; }
        public virtual int ItemHeight { get; set; }
        public ListBox.ObjectCollection Items { get; }
        public bool MultiColumn { get; set; }
        public Padding Padding { get; set; }
        public int PreferredHeight { get; }
        public override RightToLeft RightToLeft { get; set; }
        public bool ScrollAlwaysVisible { get; set; }
        public override int SelectedIndex { get; set; }
        public ListBox.SelectedIndexCollection SelectedIndices { get; }
        public object SelectedItem { get; set; }
        public ListBox.SelectedObjectCollection SelectedItems { get; }
        public virtual SelectionMode SelectionMode { get; set; }
        public bool Sorted { get; set; }
        public override string Text { get; set; }
        public int TopIndex { get; set; }
        public bool UseCustomTabOffsets { get; set; }
        public bool UseTabStops { get; set; }

        ...
        
        public event EventHandler Click;
        public event MouseEventHandler MouseClick;
        public event EventHandler SelectedIndexChanged;
        public event EventHandler TextChanged;

        public void BeginUpdate();
        public void ClearSelected();
        public void EndUpdate();
        public int FindString(string s);
        public int FindString(string s, int startIndex);
        public int FindStringExact(string s);
        public int FindStringExact(string s, int startIndex);
        public int GetItemHeight(int index);
        public Rectangle GetItemRectangle(int index);
        public bool GetSelected(int index);
        public int IndexFromPoint(Point p);
        public int IndexFromPoint(int x, int y);
        public override void Refresh();
        public override void ResetBackColor();
        public override void ResetForeColor();
        public void SetSelected(int index, bool value);
        public override string ToString();

        ...
    }
    

ListBox represents a list of choices. The list is a list of objects, so practically an item can be of any type. The key properties are the SelectedIndex and the SelectedItem. The Text property returns the text of the selected item, if any.

ListBox provides multi-selection functionality through the SelectionMode, SelectedIndices and SelectedItems.

##### CheckedListBox

    public class CheckedListBox : ListBox
    {
        public CheckedListBox();

        public CheckedListBox.CheckedIndexCollection CheckedIndices { get; }
        public CheckedListBox.CheckedItemCollection CheckedItems { get; }
        public bool CheckOnClick { get; set; }
        public object DataSource { get; set; }
        public string DisplayMember { get; set; }
        public override DrawMode DrawMode { get; set; }
        public override int ItemHeight { get; set; }
        public CheckedListBox.ObjectCollection Items { get; }
        public Padding Padding { get; set; }
        public override SelectionMode SelectionMode { get; set; }
        public bool ThreeDCheckBoxes { get; set; }
        public bool UseCompatibleTextRendering { get; set; }
        public string ValueMember { get; set; }

        ...
        
        public event EventHandler Click;
        public event EventHandler DisplayMemberChanged;
        public event ItemCheckEventHandler ItemCheck;
        public event MouseEventHandler MouseClick;
        public event EventHandler ValueMemberChanged;

        public bool GetItemChecked(int index);
        public CheckState GetItemCheckState(int index);
        public void SetItemChecked(int index, bool value);
        public void SetItemCheckState(int index, CheckState value);
        
        ...

    }
    

CheckedListBox is a ListBox where presents a check box in front of each item. CheckedIndices and CheckedItems collection properties return the checked indices and the checked items.

#### ProgressBar

    public class ProgressBar : Control
    {
        public ProgressBar();

        public override bool AllowDrop { get; set; }
        public override Image BackgroundImage { get; set; }
        public override ImageLayout BackgroundImageLayout { get; set; }
        public bool CausesValidation { get; set; }
        public override Font Font { get; set; }
        public ImeMode ImeMode { get; set; }
        public int MarqueeAnimationSpeed { get; set; }
        public int Maximum { get; set; }
        public int Minimum { get; set; }
        public Padding Padding { get; set; }
        public virtual bool RightToLeftLayout { get; set; }
        public int Step { get; set; }
        public ProgressBarStyle Style { get; set; }
        public bool TabStop { get; set; }
        public override string Text { get; set; }
        public int Value { get; set; }

        ...        


        public void Increment(int value);
        public void PerformStep();
        public override void ResetForeColor();
        public override string ToString();
    }

The ProgressBar is a classic progress bar. The Minimum and Maximum properties indicate the range of the bar while the Step property indicates the how many positins the bar moves where PerformStep() is called. Another way is to call the Increment() method.

The Value property indicates the current position of the bar.

Here is an example.

    progressBar1.Minimum = 0;
    progressBar1.Maximum = 100;
    progressBar1.Step = 1;

    for (int i = progressBar1.Minimum; i < progressBar1.Maximum; i++)
    {
        progressBar1.PerformStep();
        Application.DoEvents();
        Thread.Sleep(20);
    }

    progressBar1.Value = 0;

#### MonthCalendar

    public class MonthCalendar : Control
    {
        public MonthCalendar();

        public DateTime[] AnnuallyBoldedDates { get; set; }
        public override Color BackColor { get; set; }
        public override Image BackgroundImage { get; set; }
        public override ImageLayout BackgroundImageLayout { get; set; }
        public DateTime[] BoldedDates { get; set; }
        public Size CalendarDimensions { get; set; }
        public Day FirstDayOfWeek { get; set; }
        public override Color ForeColor { get; set; }
        public ImeMode ImeMode { get; set; }
        public DateTime MaxDate { get; set; }
        public int MaxSelectionCount { get; set; }
        public DateTime MinDate { get; set; }
        public DateTime[] MonthlyBoldedDates { get; set; }
        public Padding Padding { get; set; }
        public virtual bool RightToLeftLayout { get; set; }
        public int ScrollChange { get; set; }
        public DateTime SelectionEnd { get; set; }
        public SelectionRange SelectionRange { get; set; }
        public DateTime SelectionStart { get; set; }
        public bool ShowToday { get; set; }
        public bool ShowTodayCircle { get; set; }
        public bool ShowWeekNumbers { get; set; }
        public Size SingleMonthSize { get; }
        public Size Size { get; set; }
        public override string Text { get; set; }
        public Color TitleBackColor { get; set; }
        public Color TitleForeColor { get; set; }
        public DateTime TodayDate { get; set; }
        public bool TodayDateSet { get; }
        public Color TrailingForeColor { get; set; }

        ...
        
        public event DateRangeEventHandler DateChanged;
        public event DateRangeEventHandler DateSelected;     
        
        ...   

        public void AddAnnuallyBoldedDate(DateTime date);
        public void AddBoldedDate(DateTime date);
        public void AddMonthlyBoldedDate(DateTime date);
        public SelectionRange GetDisplayRange(bool visible);
        public MonthCalendar.HitTestInfo HitTest(Point point);
        public MonthCalendar.HitTestInfo HitTest(int x, int y);
        public void RemoveAllAnnuallyBoldedDates();
        public void RemoveAllBoldedDates();
        public void RemoveAllMonthlyBoldedDates();
        public void RemoveAnnuallyBoldedDate(DateTime date);
        public void RemoveBoldedDate(DateTime date);
        public void RemoveMonthlyBoldedDate(DateTime date);
        public void SetCalendarDimensions(int x, int y);
        public void SetDate(DateTime date);
        public void SetSelectionRange(DateTime date1, DateTime date2);
        public override string ToString();
        public void UpdateBoldedDates();

        ...
    }

MonthCalendar control is a calendar that permits the selection of a range of consecutive days. The maximum allowed number of selectable days is indicated by the MaxSelectionCount property which is 7 by default. The SelectionStart and SelectionEnd DateTime properties get or set the start and end of the selection while the SelectionRange gets or sets the range of the selection.

#### DateTimePicker

    public class DateTimePicker : Control
    {
        public static readonly DateTime MaxDateTime;
        public static readonly DateTime MinDateTime;

        public DateTimePicker();

        public override Color BackColor { get; set; }
        public override Image BackgroundImage { get; set; }
        public override ImageLayout BackgroundImageLayout { get; set; }
        public Font CalendarFont { get; set; }
        public Color CalendarForeColor { get; set; }
        public Color CalendarMonthBackground { get; set; }
        public Color CalendarTitleBackColor { get; set; }
        public Color CalendarTitleForeColor { get; set; }
        public Color CalendarTrailingForeColor { get; set; }
        public bool Checked { get; set; }
        public string CustomFormat { get; set; }
        public LeftRightAlignment DropDownAlign { get; set; }
        public override Color ForeColor { get; set; }
        public DateTimePickerFormat Format { get; set; }
        public DateTime MaxDate { get; set; }
        public static DateTime MaximumDateTime { get; }
        public DateTime MinDate { get; set; }
        public static DateTime MinimumDateTime { get; }
        public Padding Padding { get; set; }
        public int PreferredHeight { get; }
        public virtual bool RightToLeftLayout { get; set; }
        public bool ShowCheckBox { get; set; }
        public bool ShowUpDown { get; set; }
        public override string Text { get; set; }
        public DateTime Value { get; set; }

        ...
        
        public event EventHandler TextChanged;
        public event EventHandler ValueChanged;

        public override string ToString();

        ...
    }

The DateTimePicker control is actually a combo box which displays a calendar in place of the drop down list.

The key property is the Format property of type DateTimePickerFormat enum.

    public enum DateTimePickerFormat
    {
        Long = 1,
        Short = 2,
        Time = 4,
        Custom = 8,
    }
    

The Format property determines the mode of the control. When Format is Long or Short the control diplays a long or a short date accordingly, while when Format is Time it displays time values. Setting Format to Custom requires to set the CustomFormat string property too. CustomFormat accepts valid date time format strings, i.e. yyyy-MM-dd or hh:mm etc.

The Value DateTime property gets or sets the value the control represents.

#### NumericUpDown

    public class NumericUpDown : UpDownBase, ISupportInitialize
    {
        public NumericUpDown();

        public NumericUpDownAccelerationCollection Accelerations { get; }
        public int DecimalPlaces { get; set; }
        public bool Hexadecimal { get; set; }
        public decimal Increment { get; set; }
        public decimal Maximum { get; set; }
        public decimal Minimum { get; set; }
        public Padding Padding { get; set; }
        public override string Text { get; set; }
        public bool ThousandsSeparator { get; set; }
        public decimal Value { get; set; }

        public event EventHandler PaddingChanged;
        public event EventHandler TextChanged;
        public event EventHandler ValueChanged;

        public void BeginInit();
        public override void DownButton();
        public void EndInit();
        public override string ToString();
        public override void UpButton();
    }

The NumericUpDown control is a spin text box, a control that accepts and displays numeric values in a user defined range.

#### ListView

    public class ListView : Control
    {
        public ListView();

        public ItemActivation Activation { get; set; }
        public ListViewAlignment Alignment { get; set; }
        public bool AllowColumnReorder { get; set; }
        public bool AutoArrange { get; set; }
        public override Color BackColor { get; set; }
        public override ImageLayout BackgroundImageLayout { get; set; }
        public bool BackgroundImageTiled { get; set; }
        public BorderStyle BorderStyle { get; set; }
        public bool CheckBoxes { get; set; }
        public ListView.CheckedIndexCollection CheckedIndices { get; }
        public ListView.CheckedListViewItemCollection CheckedItems { get; }
        public ListView.ColumnHeaderCollection Columns { get; }
        public ListViewItem FocusedItem { get; set; }
        public override Color ForeColor { get; set; }
        public bool FullRowSelect { get; set; }
        public bool GridLines { get; set; }
        public ListViewGroupCollection Groups { get; }
        public ColumnHeaderStyle HeaderStyle { get; set; }
        public bool HideSelection { get; set; }
        public bool HotTracking { get; set; }
        public bool HoverSelection { get; set; }
        public ListViewInsertionMark InsertionMark { get; }
        public ListView.ListViewItemCollection Items { get; }
        public bool LabelEdit { get; set; }
        public bool LabelWrap { get; set; }
        public ImageList LargeImageList { get; set; }
        public IComparer ListViewItemSorter { get; set; }
        public bool MultiSelect { get; set; }
        public bool OwnerDraw { get; set; }
        public Padding Padding { get; set; }
        public virtual bool RightToLeftLayout { get; set; }
        public bool Scrollable { get; set; }
        public ListView.SelectedIndexCollection SelectedIndices { get; }
        public ListView.SelectedListViewItemCollection SelectedItems { get; }
        public bool ShowGroups { get; set; }
        public bool ShowItemToolTips { get; set; }
        public ImageList SmallImageList { get; set; }
        public SortOrder Sorting { get; set; }
        public ImageList StateImageList { get; set; }
        public override string Text { get; set; }
        public Size TileSize { get; set; }
        public ListViewItem TopItem { get; set; }
        public bool UseCompatibleStateImageBehavior { get; set; }
        public View View { get; set; }
        public int VirtualListSize { get; set; }
        public bool VirtualMode { get; set; }

        ...

        public void ArrangeIcons();
        public void ArrangeIcons(ListViewAlignment value);
        public void AutoResizeColumn(int columnIndex, ColumnHeaderAutoResizeStyle headerAutoResize);
        public void AutoResizeColumns(ColumnHeaderAutoResizeStyle headerAutoResize);
        public void BeginUpdate();
        public void Clear();
        public void EndUpdate();
        public void EnsureVisible(int index);
        public ListViewItem FindItemWithText(string text);
        public ListViewItem FindItemWithText(string text, bool includeSubItemsInSearch, int startIndex);
        public ListViewItem FindItemWithText(string text, bool includeSubItemsInSearch, int startIndex, bool isPrefixSearch);
        public ListViewItem FindNearestItem(SearchDirectionHint dir, Point point);
        public ListViewItem FindNearestItem(SearchDirectionHint searchDirection, int x, int y);
        public ListViewItem GetItemAt(int x, int y);
        public Rectangle GetItemRect(int index);
        public Rectangle GetItemRect(int index, ItemBoundsPortion portion);
        public ListViewHitTestInfo HitTest(Point point);
        public ListViewHitTestInfo HitTest(int x, int y);
        public void RedrawItems(int startIndex, int endIndex, bool invalidateOnly);
        public void Sort();
        public override string ToString();
 
        ...
    }

ListView is a Windows list view control which displays a list of items. Those items are displayed according to the setting of the View property of type View.

    public enum View
    {
        LargeIcon = 0,
        Details = 1,
        SmallIcon = 2,
        List = 3,
        Tile = 4,
    }

The ListView can have Columns when View is set to Details. The Columns property stores the settings for those columns.

The Items property is a collection of ListViewItem objects. When columns are used each item is a collection of sub-items equal to the number of columns. The ListViewItem provides the SubItems property.

Here is an example.

    LV.BeginUpdate();
    LV.Clear();
    LV.Columns.Add("Column A");
    LV.Columns.Add("Column B");

    ListViewItem LVI;

    for (int i = 0; i < 5; i++)
    {
        LVI = LV.Items.Add(i.ToString());
        LVI.SubItems.Add(LVI.Text + "-sub");
    }
    LV.EndUpdate();

#### TreeView

    public class TreeView : Control
    {
        public TreeView();

        public override Color BackColor { get; set; }
        public override Image BackgroundImage { get; set; }
        public override ImageLayout BackgroundImageLayout { get; set; }
        public BorderStyle BorderStyle { get; set; }
        public bool CheckBoxes { get; set; }
        public TreeViewDrawMode DrawMode { get; set; }
        public override Color ForeColor { get; set; }
        public bool FullRowSelect { get; set; }
        public bool HideSelection { get; set; }
        public bool HotTracking { get; set; }
        public int ImageIndex { get; set; }
        public string ImageKey { get; set; }
        public ImageList ImageList { get; set; }
        public int Indent { get; set; }
        public int ItemHeight { get; set; }
        public bool LabelEdit { get; set; }
        public Color LineColor { get; set; }
        public TreeNodeCollection Nodes { get; }
        public Padding Padding { get; set; }
        public string PathSeparator { get; set; }
        public virtual bool RightToLeftLayout { get; set; }
        public bool Scrollable { get; set; }
        public int SelectedImageIndex { get; set; }
        public string SelectedImageKey { get; set; }
        public TreeNode SelectedNode { get; set; }
        public bool ShowLines { get; set; }
        public bool ShowNodeToolTips { get; set; }
        public bool ShowPlusMinus { get; set; }
        public bool ShowRootLines { get; set; }
        public bool Sorted { get; set; }
        public ImageList StateImageList { get; set; }
        public override string Text { get; set; }
        public TreeNode TopNode { get; set; }
        public IComparer TreeViewNodeSorter { get; set; }
        public int VisibleCount { get; }

        ...

        public void BeginUpdate();
        public void CollapseAll();
        public void EndUpdate();
        public void ExpandAll();
        public TreeNode GetNodeAt(Point pt);
        public TreeNode GetNodeAt(int x, int y);
        public int GetNodeCount(bool includeSubTrees);
        public TreeViewHitTestInfo HitTest(Point pt);
        public TreeViewHitTestInfo HitTest(int x, int y);
        public void Sort();
        public override string ToString();
    }

    public class TreeNode : MarshalByRefObject, ICloneable, ISerializable
    {
        public TreeNode();
        public TreeNode(string text);
        public TreeNode(string text, TreeNode[] children);
        public TreeNode(string text, int imageIndex, int selectedImageIndex);
        public TreeNode(string text, int imageIndex, int selectedImageIndex, TreeNode[] children);

        public Color BackColor { get; set; }
        public Rectangle Bounds { get; }
        public bool Checked { get; set; }
        public virtual ContextMenu ContextMenu { get; set; }
        public virtual ContextMenuStrip ContextMenuStrip { get; set; }
        public TreeNode FirstNode { get; }
        public Color ForeColor { get; set; }
        public string FullPath { get; }
        public IntPtr Handle { get; }
        public int ImageIndex { get; set; }
        public string ImageKey { get; set; }
        public int Index { get; }
        public bool IsEditing { get; }
        public bool IsExpanded { get; }
        public bool IsSelected { get; }
        public bool IsVisible { get; }
        public TreeNode LastNode { get; }
        public int Level { get; }
        public string Name { get; set; }
        public TreeNode NextNode { get; }
        public TreeNode NextVisibleNode { get; }
        public Font NodeFont { get; set; }
        public TreeNodeCollection Nodes { get; }
        public TreeNode Parent { get; }
        public TreeNode PrevNode { get; }
        public TreeNode PrevVisibleNode { get; }
        public int SelectedImageIndex { get; set; }
        public string SelectedImageKey { get; set; }
        public int StateImageIndex { get; set; }
        public string StateImageKey { get; set; }
        public object Tag { get; set; }
        public string Text { get; set; }
        public string ToolTipText { get; set; }
        public TreeView TreeView { get; }

        public void BeginEdit();
        public virtual object Clone();
        public void Collapse();
        public void Collapse(bool ignoreChildren);
        public void EndEdit(bool cancel);
        public void EnsureVisible();
        public void Expand();
        public void ExpandAll();
        public static TreeNode FromHandle(TreeView tree, IntPtr handle);
        public int GetNodeCount(bool includeSubTrees);
        public void Remove();
        public void Toggle();
        public override string ToString();
    }

TreeView is a Windows tree view control which displays a list of labeled items. Each item is a TreeNode object. The tree itself and each TreeNode object provide the Nodes property which is the collection of its nodes.

Here is an example.

    TV.BeginUpdate();
    TV.Nodes.Clear();

    for (int i = 0; i < 3; i++)
    {
        TV.Nodes.Add("i " + i.ToString());
        for (int j = 0; j < 3; j++)
        {
            TV.Nodes[i].Nodes.Add("j " + j.ToString());
            for (int k = 0; k < 3; k++)
            {
                TV.Nodes[i].Nodes[j].Nodes.Add("k " + k.ToString());
            }
        }
    }
    TV.EndUpdate();

#### Dialog boxes

Windows Forms provides a set of common dialog boxes: OpenFileDialog, SaveFileDialog, FolderBrowserDialog, FontDialog and ColorDialog. They all inherit, directly or indirectly, from CommonDialog class.

To use one of those dialog boxes just create the object, set some properties and then call ShowDialog().

Here is an example of using the OpenFileDialog to load an PictureBox.

    using (OpenFileDialog Dlg = new OpenFileDialog())
    {
        Dlg.Title = "Select image";
        Dlg.InitialDirectory = @"C:\";
        Dlg.Filter = "Image Files(*.BMP;*.JPG;*.GIF)|*.BMP;*.JPG;*.GIF|All files (*.*)|*.*";
        Dlg.CheckFileExists = true;
        Dlg.CheckPathExists = true;

        if (Dlg.ShowDialog() == DialogResult.OK)
        {
            picBox.Load(Dlg.FileName);
        }                    
    }

#### PictureBox

    public class PictureBox : Control, ISupportInitialize
    {
        public PictureBox();

        public override bool AllowDrop { get; set; }
        public BorderStyle BorderStyle { get; set; }
        public bool CausesValidation { get; set; }
        public Image ErrorImage { get; set; }
        public override Font Font { get; set; }
        public override Color ForeColor { get; set; }
        public Image Image { get; set; }
        public string ImageLocation { get; set; }
        public ImeMode ImeMode { get; set; }
        public Image InitialImage { get; set; }
        public override RightToLeft RightToLeft { get; set; }
        public PictureBoxSizeMode SizeMode { get; set; }
        public int TabIndex { get; set; }
        public bool TabStop { get; set; }
        public override string Text { get; set; }
        public bool WaitOnLoad { get; set; }
 
        ...

        public void CancelAsync();
        public void Load();
        public void Load(string url);
        public void LoadAsync();
        public void LoadAsync(string url);
        public override string ToString();
    }
    

The PictureBox control is used to display bitmap, icon, metafile, JPEG, GIF and PNG files. The key is the Image property which is an instance of the Image class.

    public abstract class Image : MarshalByRefObject, ISerializable, ICloneable, IDisposable
    {
        public int Flags { get; }
        public Guid[] FrameDimensionsList { get; }
        public int Height { get; }
        public float HorizontalResolution { get; }
        public ColorPalette Palette { get; set; }
        public SizeF PhysicalDimension { get; }
        public PixelFormat PixelFormat { get; }
        public int[] PropertyIdList { get; }
        public PropertyItem[] PropertyItems { get; }
        public ImageFormat RawFormat { get; }
        public Size Size { get; }
        public object Tag { get; set; }
        public float VerticalResolution { get; }
        public int Width { get; }

        public object Clone();
        public void Dispose();
        public static Image FromFile(string filename);
        public static Image FromFile(string filename, bool useEmbeddedColorManagement);
        public static Bitmap FromHbitmap(IntPtr hbitmap);
        public static Bitmap FromHbitmap(IntPtr hbitmap, IntPtr hpalette);
        public static Image FromStream(Stream stream);
        public static Image FromStream(Stream stream, bool useEmbeddedColorManagement);
        public static Image FromStream(Stream stream, bool useEmbeddedColorManagement, bool validateImageData);
        public RectangleF GetBounds(ref GraphicsUnit pageUnit);
        public EncoderParameters GetEncoderParameterList(Guid encoder);
        public int GetFrameCount(FrameDimension dimension);
        public static int GetPixelFormatSize(PixelFormat pixfmt);
        public PropertyItem GetPropertyItem(int propid);
        public Image GetThumbnailImage(int thumbWidth, int thumbHeight, Image.GetThumbnailImageAbort callback, IntPtr callbackData);
        public static bool IsAlphaPixelFormat(PixelFormat pixfmt);
        public static bool IsCanonicalPixelFormat(PixelFormat pixfmt);
        public static bool IsExtendedPixelFormat(PixelFormat pixfmt);
        public void RemovePropertyItem(int propid);
        public void RotateFlip(RotateFlipType rotateFlipType);
        public void Save(string filename);
        public void Save(Stream stream, ImageFormat format);
        public void Save(string filename, ImageFormat format);
        public void Save(Stream stream, ImageCodecInfo encoder, EncoderParameters encoderParams);
        public void Save(string filename, ImageCodecInfo encoder, EncoderParameters encoderParams);
        public void SaveAdd(EncoderParameters encoderParams);
        public void SaveAdd(Image image, EncoderParameters encoderParams);
        public int SelectActiveFrame(FrameDimension dimension, int frameIndex);
        public void SetPropertyItem(PropertyItem propitem);

        public delegate bool GetThumbnailImageAbort();
    }
 

The PictureBox.SizeMode property, of type PictureBoxSizeMode enum

    public enum PictureBoxSizeMode
    {
        Normal = 0,
        StretchImage = 1,
        AutoSize = 2,
        CenterImage = 3,
        Zoom = 4,
    }
    

affects how the control displays the image.

Here is how to load an image to the PictureBox.

    picBox.Image = Image.FromFile("C:\Image.bmp");

#### Menus, tool bars and status bars

The old controls are the MainMenu, ContextMenu, ToolBar and StatusBar. Although those controls still exist, a new set of controls is introduced: strip controls.

MenuStrip, ContextMenuStrip, ToolStrip and StatusStrip are the preferred controls now. MS Visual Studio provides design time support for adding and setting up all those controls.

Form class provides a Menu property of type MainMenu and a MainMenuStrip property of type MenuStrip. Dropping a MainMenu or a MenuStrip on a form it automatically assignes the relevant form property.

Here is how to create a main menu tree manually.

    MenuStrip mnuMain = new MenuStrip();
    mnuMain.Dock = DockStyle.Top;

    ToolStripMenuItem mnuFile = new ToolStripMenuItem("File");
    mnuMain.Items.Add(mnuFile);

    ToolStripMenuItem mnuExit = new ToolStripMenuItem("Exit");
    mnuFile.DropDownItems.Add(mnuExit);

    this.MainMenuStrip = mnuMain;            
    this.Controls.Add(mnuMain);
    

A context menu, sometimes called local menu or popup menu, is a menu that a control displays when it is right-clicked.

Control class provides a ContextMenu property of type ContextMenu and a ContextMenuStrip property of type ContextMenuStrip. Thus any control can have its own context menu.

Here is how to create a context menu tree manually.

    ContextMenuStrip mnuContext = new ContextMenuStrip();

    ToolStripMenuItem mnuA = new ToolStripMenuItem("A");
    mnuContext.Items.Add(mnuA);

    ToolStripMenuItem mnuB = new ToolStripMenuItem("B");
    mnuA.DropDownItems.Add(mnuB);

    this.ContextMenuStrip = mnuContext;
    
    

A ToolStrip is a tool bar that may contain buttons, labels, text boxes etc. Here is how to create a ToolStrip manually.

    ToolStrip toolBar = new ToolStrip();
    ToolStripButton btnExit = new ToolStripButton("Exit");
    toolBar.Items.Add(btnExit);
    this.Controls.Add(toolBar);

A StatusStrip is a status bar that may contain labels, progress bars etc. Here is how to create a StatusStrip manually.

    StatusStrip statusBar = new StatusStrip();
    ToolStripStatusLabel lblText = new ToolStripStatusLabel("this is a status bar label");
    statusBar.Items.Add(lblText);
    this.Controls.Add(statusBar);
    

#### Other standard controls and components

##### Label and LinkLabel

Both controls display read-only text to the user. The LinkLabel displays hyperlinks. They both provide a Click event.

##### DataGridView

The DataGridView is a huge control. It displays tabular data and can be used either in boud or in unbound (no-datasource) mode. The functionality that control provides is tremendous. It also provides great extensibility.

DataGridView is described in the data access tutorial.

##### DataGrid

The DataGrid control is the initial attempt of the .Net to have a grid control.

##### WebBrowser

WebBrowser hosts web pages and provides navigation capabilities.

    webBrowser1.Navigate(edtUrl.Text);
    

##### ImageList

The ImageList component maintains an indexed collection of same-sized images. Many controls, the Button for example, provide an ImageList and an ImageIndex property. Setting those properties to valid values makes the control to display the corresponding image from the ImageList.

##### Timer

    public class Timer : Component
    {
        public Timer();
        public Timer(IContainer container);

        public virtual bool Enabled { get; set; }
        public int Interval { get; set; }
        public object Tag { get; set; }

        public event EventHandler Tick;

        public void Start();
        public void Stop();
        public override string ToString();
    }
    

The Timer component is a simple timer. It provides the Tick event which is triggered on Interval periods, when Enabled is true.

    private void Timer_Tick(object sender, EventArgs e)
    {
        lblDateTime.Text = DateTime.Now.ToShortDateString() + "  " + DateTime.Now.ToShortTimeString();
    }    


 

##### NotifyIcon

    public sealed class NotifyIcon : Component
    {
        public NotifyIcon();
        public NotifyIcon(IContainer container);

        public ToolTipIcon BalloonTipIcon { get; set; }
        public string BalloonTipText { get; set; }
        public string BalloonTipTitle { get; set; }
        public ContextMenu ContextMenu { get; set; }
        public ContextMenuStrip ContextMenuStrip { get; set; }
        public Icon Icon { get; set; }
        public object Tag { get; set; }
        public string Text { get; set; }
        public bool Visible { get; set; }

        public event EventHandler BalloonTipClicked;
        public event EventHandler BalloonTipClosed;
        public event EventHandler BalloonTipShown;
        public event EventHandler Click;
        public event EventHandler DoubleClick;
        public event MouseEventHandler MouseClick;
        public event MouseEventHandler MouseDoubleClick;
        public event MouseEventHandler MouseDown;
        public event MouseEventHandler MouseMove;
        public event MouseEventHandler MouseUp;

        public void ShowBalloonTip(int timeout);
        public void ShowBalloonTip(int timeout, string tipTitle, string tipText, ToolTipIcon tipIcon);
    }
    

The NotifyIcon displays an icon in the Windows task bar notification area. Key properties are the Text, the Icon and the ContexMenu or ContextMenuStrip.

The ShowBalloonTip() method displays a ballon tip in the notification area for a specified period.

    notifyIcon1.ShowBalloonTip(2000, "Tip Title", "Hi there!", ToolTipIcon.Info);
    

#### The remarkable UserControl control

The UserControl class is the base for creating composite re-usable controls.

The path to create a new UserControl is Solution Explorer | Project | Add | User Control. This action displays a design surface where the user can drop and arrange controls. Those controls become part of the UserControl. In fact a UserControl has many similarities to a Form. It's a partial class and its constructor includes an InitializeComponent() call which can be found in a XXXX.Designer.cs source file.

A UserControl is a re-usable element just like any built-in control. After building the project, the new UserControl is contained in the ToolBox along with the other controls ready to be dropped on a form or anyother UserControl (recursion is not allowed).

Here is an example UserControl which contains some text boxes.

    public partial class PersonUserControl : UserControl
    {
        public PersonUserControl()
        {
            InitializeComponent();
        }

        public string Title
        {
            get { return gboBox.Text; }
            set { gboBox.Text = value; }
        }

        public string PersonName
        {
            get { return edtName.Text; }
            set { edtName.Text = value; }
        }

        public string Phone
        {
            get { return edtPhone.Text; }
            set { edtPhone.Text = value; }
        }

        public string EMail
        {
            get { return edtEMail.Text; }
            set { edtEMail.Text = value; }
        }
    }

### Configuration: application and user settings

Most applications need a way to store and retrieve information regarding things such as database connection strings, form locations and user preferences. Traditionally that kind of information was stored into initialization files, known as ini files. Windows Forms has no support for those traditional ini files. Instead it provides a whole new configuration functionality.

The .Net Framework 2.0 changed that functionality again introducing the System.Configuration namespace which is the place where most of the types regarding configuration reside.

#### Configuration files

Windows Forms configuration differentiates two types of configuration information:

*   application settings
*   user settings

Application settings, which considered (and they actually are) read only, are stored in a file named as ApplicationName.exe.config, where ApplicationName is the name of the executable file. That config file can be found at the application folder. A system administrator or support personnel may alter the content of that file manually.

User settings, which are read-write settings, are stored in a file named as user.config. That config file can be found at the user profile folder, which may vary from system to system. The application can alter the content of that file by saving user preferences. As it is obvious, a separate user config file will be created for each user that logs in to the system and uses the application.

Both those config files are plain xml files.

At design-time the easiest way to create application and user settings is the Settings tab page of the Project Properties. (Solution Explorer | Project | Properties | Settings). That Settings page provides a user interface where the user can define application and user settings, their name, which must be unique, data type and default value. An app.config file is created and added to the project when the user uses that Settings tab page and is where those settings are saved.

Do not confuse the app.config file with the ApplicationName.exe.config file. The app.config is part of project, just like any source file. The ApplicationName.exe.config is the application configuration file.

Here is an ApplicationName.exe.config which contains settings for an application setting named AppValue and a user setting named UserValue.

    <?xml version="1.0" encoding="utf-8" ?>
    <configuration>
        <configSections>
        ...
        </configSections>
        <userSettings>
            <Lessons.Properties.Settings>
                <setting name="UserValue" serializeAs="String">
                    <value>0</value>
                </setting>
            </Lessons.Properties.Settings>
        </userSettings>
        <applicationSettings>
            <Lessons.Properties.Settings>
                <setting name="AppValue" serializeAs="String">
                    <value>Hi there</value>
                </setting>
            </Lessons.Properties.Settings>
        </applicationSettings>
    </configuration>    

Although that ApplicationName.exe.config file contains a userSettings element, its content is considered read-only for the application. The userSettings element provides the default values for user settings. The actual user settings are stored in the user.config file. Here is an example of a user.config file where the UserValue setting has the value of 65.

    <?xml version="1.0" encoding="utf-8"?>
    <configuration>
        <userSettings>
            <Lessons.Properties.Settings>
                <setting name="UserValue" serializeAs="String">
                    <value>65</value>
                </setting>
            </Lessons.Properties.Settings>
        </userSettings>
    </configuration>

#### Accessing configuration settings by code

MS Visual Studio creates a Properties folder when creating a new project. Inside that Properties folder there is a Settins.settings node. Double clicking that node displays the same user interface as the path Solution Explorer | Project | Properties | Settings where the user can edit configuration settings. Inside that node there is a Settings.Designer.cs source code file which is maintained by the IDE.

That Settings.Designer.cs source code file contains a Settings class which inherits from System.Configuration.ApplicationSettingsBase. That Settings class provides a read-only property for each application setting and a read-write property for each user setting the user adds to the Settings.settings user interface.

Here is that class.

    namespace Lessons.Properties {
        
        
        [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "9.0.0.0")]
        internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
            
            private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
            
            public static Settings Default {
                get {
                    return defaultInstance;
                }
            }
            
            [global::System.Configuration.ApplicationScopedSettingAttribute()]
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.Configuration.DefaultSettingValueAttribute("Hi there")]
            public string AppValue {
                get {
                    return ((string)(this["AppValue"]));
                }
            }
            
            [global::System.Configuration.UserScopedSettingAttribute()]
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.Configuration.DefaultSettingValueAttribute("0")]
            public int UserValue {
                get {
                    return ((int)(this["UserValue"]));
                }
                set {
                    this["UserValue"] = value;
                }
            }
        }
    }

That Settings class resides in its own namespace. So to use that class a using directive is required.

Here is how to read the AppValue and how to read and write the UserValue.

    private void btnGetAppValue_Click(object sender, EventArgs e)
    {
        MessageBox.Show(Settings.Default.AppValue);            
    }

    private void btnGetUserValue_Click(object sender, EventArgs e)
    {
        MessageBox.Show(Settings.Default.UserValue.ToString());
    }

    private void btnSetUserValue_Click(object sender, EventArgs e)
    {
        Settings.Default.UserValue = Convert.ToInt32(edtUserValue.Value);

        /* save the change */
        Settings.Default.Save();
    }

The mystery of where the user.config is saved, is revealed by using the System.Configuration.Configuration class and the System.Configuration.ConfigurationManager class, something that requires a reference to the System.configuration.dll assembly.

    private void btnUserConfigLocation_Click(object sender, EventArgs e)
    {
        Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.PerUserRoamingAndLocal);

        if (File.Exists(config.FilePath))
            MessageBox.Show(config.FilePath);
        else
            MessageBox.Show("user.config not found");
    }
    

A word on configuration: Configuration is an area where the functionality provided by .Net Framework is very far from being perfect. Although the whole configuration system is revised with CLR 2.0 it is still too complex and rigid.

### Application resources

An application may contain non source code data, such as images, strings, audio and even binary data, in a format that makes that data reusable by multiple controls and other types in that same application. That data is known as application resources or just resources.

Each resource item contained in an application has a resource type and it is identified by a unique name.

For example, two or more forms may use the same image resource for their buttons. Furthermore having strings as resources makes it easy to localize the application for a certain culture.

The System.Resources namespace contains clases, interfaces and other types that are resource related. Those classes allow to create, read, write and in general hanle application resources. The most important is the System.Resources.ResourceManager class which gives access to resources stored in the main assembly or in resource satellite assemblies.

Localized (adapted to other languages/cultures) applications, place localized strings and other localized resources in, so-called, satellite assemblies, which are assemblies that contain resources only and no code at all (we'll describe localization later).

    public class ResourceManager
    {
        public static readonly int HeaderVersionNumber;
        public static readonly int MagicNumber;

        public ResourceManager(Type resourceSource);
        public ResourceManager(string baseName, Assembly assembly);
        public ResourceManager(string baseName, Assembly assembly, Type usingResourceSet);

        public virtual string BaseName { get; }
        public virtual bool IgnoreCase { get; set; }
        public virtual Type ResourceSetType { get; }

        public static ResourceManager CreateFileBasedResourceManager(string baseName, string resourceDir, Type usingResourceSet);
        public virtual object GetObject(string name);
        public virtual object GetObject(string name, CultureInfo culture);
        public virtual ResourceSet GetResourceSet(CultureInfo culture, bool createIfNotExists, bool tryParents);
        public UnmanagedMemoryStream GetStream(string name);
        public UnmanagedMemoryStream GetStream(string name, CultureInfo culture);
        public virtual string GetString(string name);
        public virtual string GetString(string name, CultureInfo culture);
        public virtual void ReleaseAllResources();
    }
    

see also:

*   [http://en.wikipedia.org/wiki/.NET_assembly#Satellite_assemblies]( http://en.wikipedia.org/wiki/.NET_assembly#Satellite_assemblies)

#### Adding resources to a project

Regarding their location, resouces are in one of two types

*   linked resources, that is external files
*   embedded resources, that is resources embedded directly into the application.

Linked resources require deployment. This tutorial does not describe linked resources. Embedded resources do not require deployment since they directly contained into the application.

When the user creates a new Windows Forms project with the MS Visual Studio, the IDE adds a Property folder to the project. That Property folder contains a Resources.resx node. That Resources.resx node is actually a disk file in that folder with that same name.

Resx files are just plain xml files that contain resources either directly or references to external files. Building the project embedds those resources into the application.

Here is a portion of such a Resources.resx file from an example project that contains three resource items

*   a string
*   an image
*   an unmanaged dll.

    <?xml version="1.0" encoding="utf-8"?>
    <root>
      
      ...
      ...
      ...
      
      <data name="cslogo" type="System.Resources.ResXFileRef, System.Windows.Forms">
        <value>..\Resources\cslogo.png;System.Drawing.Bitmap, System.Drawing, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a</value>
      </data>
      <data name="string_resource" xml:space="preserve">
        <value>This is a resource string</value>
      </data>
      <data name="TestLib" type="System.Resources.ResXFileRef, System.Windows.Forms">
        <value>..\TestLib.dll;System.Byte[], mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089</value>
      </data>
    </root>

Double clicking on that Resources.resx node displays the Resource Designer. Another path to the Resource Designer is Solution Explorer | right click on Project | Properties | Resources.

Resource Designer provides an intuitive user interface for adding, removing and editing application resources. Depending on the resource type a specific editor may be available such as the Image Editor, the String Editor etc, by double clicking on the resource.

Resource Designer provides a Resource View Selector menu, found at the top-left corner of the Resource Designer, which displays a project's resources by type. An Add Resource and Remove Resouce menu item is also provided.

NOTE: MS Visual Studio 2008 installs an Image Library. This library can be found at C:\Program Files\Microsoft Visual Studio 9.0\Common7\VS2008ImageLibrary.

#### Accessing resources by code at runtime

Along with the Resources.resx node (and file) in the Properties folder, MS Visual Studio creates a Resources.Designer.cs source code file. That file, which is maintained by the IDE, contains a Resources class which initializes a ResourceManager instance as a private field and contains a read-only property for each resource item added using the Resource Designer.

Here is such a Resources class for a project containing three resource items:

*   a string
*   an image
*   an unmanaged dll.

    namespace Lessons.Properties {
        using System;
        
        
        /// <summary>
        ///   A strongly-typed resource class, for looking up localized strings, etc.
        /// </summary>
        // This class was auto-generated by the StronglyTypedResourceBuilder
        // class via a tool like ResGen or Visual Studio.
        // To add or remove a member, edit your .ResX file then rerun ResGen
        // with the /str option, or rebuild your VS project.
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "2.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
        internal class Resources {
            
            private static global::System.Resources.ResourceManager resourceMan;
            
            private static global::System.Globalization.CultureInfo resourceCulture;
            
            [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
            internal Resources() {
            }
            
            /// <summary>
            ///   Returns the cached ResourceManager instance used by this class.
            /// </summary>
            [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
            internal static global::System.Resources.ResourceManager ResourceManager {
                get {
                    if (object.ReferenceEquals(resourceMan, null)) {
                        global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Lessons.Properties.Resources", typeof(Resources).Assembly);
                        resourceMan = temp;
                    }
                    return resourceMan;
                }
            }
            
            /// <summary>
            ///   Overrides the current thread's CurrentUICulture property for all
            ///   resource lookups using this strongly typed resource class.
            /// </summary>
            [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
            internal static global::System.Globalization.CultureInfo Culture {
                get {
                    return resourceCulture;
                }
                set {
                    resourceCulture = value;
                }
            }
            
            internal static System.Drawing.Bitmap cslogo {
                get {
                    object obj = ResourceManager.GetObject("cslogo", resourceCulture);
                    return ((System.Drawing.Bitmap)(obj));
                }
            }
            
            /// <summary>
            ///   Looks up a localized string similar to This is a resource string.
            /// </summary>
            internal static string string_resource {
                get {
                    return ResourceManager.GetString("string_resource", resourceCulture);
                }
            }
            
            internal static byte[] TestLib {
                get {
                    object obj = ResourceManager.GetObject("TestLib", resourceCulture);
                    return ((byte[])(obj));
                }
            }
        }
    }

That Resources class allows easy access to any resource item added.

    pictureBox1.Image = Resources.cslogo;
    
    ...
    
    MessageBox.Show(Resources.string_resource);
    
    

That example project contains an unmanaged dll, written with Delphi. Here is the Pascal code of that simple dll.

    library TestLib;    

    function Add(X, Y: Integer): Integer; stdcall;
    begin
      Result := X + Y;
    end;

    exports
      Add;        

    begin
    end.

That dll is added as a resource item of the "file" resource type, to the project. The Resources class returns the dll as a byte array. The example project reads that dll resource item data, saves it to the disk as a dll and then calls a function provided by that dll.

    /* The TestLib resource item is an unmanaged dll. This method saves the resource
       item to the disk */
    static internal void PrepareDll()
    {
        string FileName = Application.StartupPath + Path.DirectorySeparatorChar + "TestLib.dll";
        if (!File.Exists(FileName))
            File.WriteAllBytes(FileName, Resources.TestLib);
    }

    /* import a dll function */
    [DllImport("TestLib.dll")]
    public static extern int Add(int X, int Y);


    /* call a dll function */
    private void btnCallDllFunc_Click(object sender, EventArgs e)
    {
        int Res = Add(1, 2);
        MessageBox.Show(Res.ToString());
    }
    
    

### World-ready applications

An application targeting the international market is not an unusual situation nowadays. That kind of multilingual applications need to be carefully designed and implemented taking into account not only displayed text translation issues. Number formatting, Date and time formatting and calendars are among the issues an international application has to consider.

MS Visual Studio IDE provides tools and FCL provides classes and types for creating world-ready applications. Those classes and types can be found in System.Globalization namespace.

see also:

*   [http://en.wikipedia.org/wiki/Internationalization_and_localization](   http://en.wikipedia.org/wiki/Internationalization_and_localization)
*   [http://www.i18nguy.com/](http://www.i18nguy.com/)

#### The notion of culture and the CultureInfo class

Culture is a term used by .Net and defines a group of settings regarding

*   the user interface language
*   the writing system
*   the calendar used
*   the formatting for number, currency, and date-time values
*   and sorting strings.

Culture, as a term, is somehow semantically equal to the term Locale, used in unmanaged programming.

A .Net culture (and an unmanaged Locale) is identified by a name, which is a string of the following format

    <LanguageCode>-<Country/RegionCode>
    

Here is, for example, the names of the English cultures supported by CRL.

    en          English  
    en-AU       English (Australia)      
    en-BZ       English (Belize)      
    en-CA       English (Canada)      
    en-029      English (Caribbean)      
    en-IE       English (Ireland)      
    en-JM       English (Jamaica)      
    en-NZ       English (New Zealand)      
    en-PH       English (Philippines)      
    en-ZA       English (South Africa)      
    en-TT       English (Trinidad and Tobago)
    en-GB       English (United Kingdom)     
    en-US       English (United States)
 
     

NOTE: The RFC 4646 describes the "Tags for Identifying Languages". The ISO 639-1 describes the LanguageCode. The ISO 3166 describes the Country/RegionCode.

The reason for the distinction between LanguageCode and Country/RegionCode is that although two distinct countries or country regions may speak the same language, they may have differences in displaying date or numbers and they may use a totally different calendar.

The System.Globalization.CultureInfo class represents a culture.

    public class CultureInfo : ICloneable, IFormatProvider
    {
        public CultureInfo(int culture);
        public CultureInfo(string name);
        public CultureInfo(int culture, bool useUserOverride);
        public CultureInfo(string name, bool useUserOverride);

        public virtual Calendar Calendar { get; }
        public virtual CompareInfo CompareInfo { get; }
        public CultureTypes CultureTypes { get; }
        public static CultureInfo CurrentCulture { get; }
        public static CultureInfo CurrentUICulture { get; }
        public virtual DateTimeFormatInfo DateTimeFormat { get; set; }
        public virtual string DisplayName { get; }
        public virtual string EnglishName { get; }
        public string IetfLanguageTag { get; }
        public static CultureInfo InstalledUICulture { get; }
        public static CultureInfo InvariantCulture { get; }
        public virtual bool IsNeutralCulture { get; }
        public bool IsReadOnly { get; }
        public virtual int KeyboardLayoutId { get; }
        public virtual int LCID { get; }
        public virtual string Name { get; }
        public virtual string NativeName { get; }
        public virtual NumberFormatInfo NumberFormat { get; set; }
        public virtual Calendar[] OptionalCalendars { get; }
        public virtual CultureInfo Parent { get; }
        public virtual TextInfo TextInfo { get; }
        public virtual string ThreeLetterISOLanguageName { get; }
        public virtual string ThreeLetterWindowsLanguageName { get; }
        public virtual string TwoLetterISOLanguageName { get; }
        public bool UseUserOverride { get; }

        public void ClearCachedData();
        public virtual object Clone();
        public static CultureInfo CreateSpecificCulture(string name);
        public override bool Equals(object value);
        public CultureInfo GetConsoleFallbackUICulture();
        public static CultureInfo GetCultureInfo(int culture);
        public static CultureInfo GetCultureInfo(string name);
        public static CultureInfo GetCultureInfo(string name, string altName);
        public static CultureInfo GetCultureInfoByIetfLanguageTag(string name);
        public static CultureInfo[] GetCultures(CultureTypes types);
        public virtual object GetFormat(Type formatType);
        public override int GetHashCode();
        public static CultureInfo ReadOnly(CultureInfo ci);
        public override string ToString();
    }

The read-only Name property is the culture name and it is passed when an instance of the CultureInfo class is created.

NOTE: The CultureInfo class documentation provides a full list of predefined culture names.

see also:

*   [http://www.ietf.org/rfc/rfc4646.txt](   http://www.ietf.org/rfc/rfc4646.txt)
*   [http://en.wikipedia.org/wiki/ISO_639-1](http://en.wikipedia.org/wiki/ISO_639-1)
*   [http://en.wikipedia.org/wiki/ISO_3166](http://en.wikipedia.org/wiki/ISO_3166)

#### Invariant, neutral and specific cultures

There are three culture groups:

*   the invariant culture,
*   the neutral cultures and
*   the specific cultures.

The invariant culture is said to be "culture-independent". There is just one invariant culture. The invariant culture is associated with the English language but not with any country or region. The CultureInfo.InvariantCulture property returns that invariant culture. Also passing an empty string ("") to the CultureInfo constructor creates a CultureInfo instance which represents the invariant culture.

    CultureInfo invariant = new CultureInfo("");

A neutral culture is associated with a certain language but not with any country or region. Passing just the language tag to the CultureInfo constructor creates a CultureInfo instance which represents a invariant culture.

    CultureInfo neutralFrench = new CultureInfo("fr");
    CultureInfo neutralItalian = new CultureInfo("it");
    

The CultureInfo.IsNeutralCulture boolean property returns true to indicate a neutral culture.

A specific culture is associated with a certain language and with a certain country or region.

    CultureInfo specificFrench = new CultureInfo("fr-CA");      // French (Canada) 
    CultureInfo specificItalian = new CultureInfo("it-CH");     // Italian (Switzerland) 
    

In string comparisons and value formatting only specific cultures can be used. This is because the required information for such kind of operations is only available by a specific culture. It is possible though to create a specific culture using a neutral culture by calling the CultureInfo.CreateSpecificCulture() method and passing a neutral culture.

    CultureInfo specific = CultureInfo.CreateSpecificCulture("fr");

The CreateSpecificCulture() method creates a default specific culture for passed in neutral culture.

#### Culture hierarchy

Cultures form a hierarchy. CultureInfo class provides the Parent read only property. The ultimate Parent is the invariant culture. All neutral cultures have the invariant culture as their Parent. Specific cultures have a certain neutral culture as their Parent.

    ""              (invariant culture)
        en
            en-AU   
            en-CA   
            en-IE    
        
        fr
            fr-FR
            fr-CA 

#### Application culture

There are two settings that affect the operation of an application (strictly speaking, of a thread). The CurrentUICulture and CurrentCulture properties of the System.Threading.Thread class.

    public CultureInfo CurrentUICulture { get; set; }
    public CultureInfo CurrentCulture { get; set; }
    

The System.Windows.Forms.Application class provides a CurrentCulture property too. Setting that Application.CurrentCulture property actually sets the CurrentCulture property of the primary thread.

##### CurrentUICulture

The current UI culture (Thread.CurrentUICulture) setting determines which localized resources will be loaded by the ResourceManager and used by the application in displaying forms, dialog boxes, etc.

The Thread.CurrentUICulture accepts any type of culture: invariant, neutral or specific.

If the CurrentUICulture property is not set explicitly by application code, it is set automatically to the UI language of the operating system or to the relevant setting of the Control Panel Regional and Language Settings applet.

    Thread.CurrentThread.CurrentUICulture = new CultureInfo("fr");
    
 

##### CurrentCulture

The current culture (Thread.CurrentCulture) setting determines number, currency and date-time formatting, text sorting order, string comparisons etc.

The Thread.CurrentCulture accepts specific cultures only and the invariant culture. This is because Thread.CurrentCulture is not a language setting. It affects operations on data (formatting etc) and therefore must be set to a culture associated with a geographical region

If the CurrentCulture property is not set explicitly by application code, it is set automatically to the User Locale of the operating system, which can be set using the Control Panel Regional and Language Settings applet.

    Thread.CurrentThread.CurrentCulture = new CultureInfo("fr-FR");
    

#### User overrides

The current culture (Locale) of the operating system provides the default values for things such as the date or the decimal separator and the currency symbol. Those settings are accessible through the Control Panel Regional and Language Settings applet. Thus a user of a computer might use that applet to change, that is override, those default settings.

The CultureInfo class provides a constructor

    public CultureInfo(string name, bool useUserOverride);
    

which can be used when creating a CultureInfo instance for the current culture, and accepts a useUserOverride boolean parameter in order to control what to do with possible user overrides of those values.

#### RegionInfo class

The System.Globalization.RegionInfo class represents a country/region.

    public class RegionInfo
    {
        public RegionInfo(int culture);
        public RegionInfo(string name);

        public virtual string CurrencyEnglishName { get; }
        public virtual string CurrencyNativeName { get; }
        public virtual string CurrencySymbol { get; }
        public static RegionInfo CurrentRegion { get; }
        public virtual string DisplayName { get; }
        public virtual string EnglishName { get; }
        public virtual int GeoId { get; }
        public virtual bool IsMetric { get; }
        public virtual string ISOCurrencySymbol { get; }
        public virtual string Name { get; }
        public virtual string NativeName { get; }
        public virtual string ThreeLetterISORegionName { get; }
        public virtual string ThreeLetterWindowsRegionName { get; }
        public virtual string TwoLetterISORegionName { get; }

        public override bool Equals(object value);
        public override int GetHashCode();
        public override string ToString();
    }

Although it is possible to create a RegionInfo instance passing a country or region name, that is a two-letter string code as defined in ISO 3166, it is better to use a specific culture name, such as fr-FR, en-US etc.

The RegionInfo class is just a group of informational read-only properties.

#### Custom cultures and the CultureAndRegionInfoBuilder class

Only those cultures that are predefined by the CultureInfo class are initially available to applications. An application can use the System.Globalization.CultureAndRegionInfoBuilder class (requires a reference to the sysglobl.dll assembly) in order to create a custom culture which may be based on an existing culture or not, and install that new custome culture on a system. Such an installed custom culture can then be used by any application.

see also:

*   [http://www.codeproject.com/KB/books/CustomCultures.aspx](   http://www.codeproject.com/KB/books/CustomCultures.aspx)
*   [http://www.codeproject.com/KB/dotnet/CultureAndRegionInfoTool.aspx](http://www.codeproject.com/KB/dotnet/CultureAndRegionInfoTool.aspx)

#### "There Ain't No Such Thing As Plain Text" (as Joel Spolsky said)

Text display in computers has a long history. Here is a brief historical summary.

In bottom line, computers represent everything using numbers. Characters is not an exception to this rule. At the beginning of the story, a single byte was more than enough to represent a single character. A byte has enough room to represent numbers from 0 to 255. At that time only the english language was used which has just 26 letters. So a byte is more than enough.

##### ASCII

The ASCII code is a table that maps numbers to characters. Initially ASCII code used numbers from 0 to 127, that is just seven bits, to map and represent all english characters, plus some other printable and non printable symbols, such as the Carriage Return or the comma and the point.

##### OEM character sets

Since there was enough room to that single byte for 128 more characters, OEM (Original Equipment Manufacturer) character sets appeared. An OEM character set has exactly the same characters at the same positions as the ASCII code, from 0 to 127. And it uses 128 to 255 to represent national characters of a certain national alphabet (Greek, Cyrillic, etc). There were many many OEM character sets, sometimes two or more for the same national alphabet having characters at totally different positions. That was the far-west era. Too much freedom and no law at all.

##### ANSI code pages

At some time OEM character sets standardized as ANSI code pages. It's the MS Windows era. ANSI code pages like OEM character sets are an exact mapping of the ASCII code from 0 to 127, while 128 to 255 is used to represent characters of a national alphabet. It's a mistake to assume that an OEM character set is promoted to an ANSI code page. Compare the OEM 737 (Greek) to the ANSI-1253 (Greek) to see the differences.

##### Double-byte and Multi-byte character sets

Some Asian alphabets have thousands of characters and a byte could not represent them all. Thus there was some character sets using one byte for some characters and two or more bytes for other characters.

##### Unicode

The final solution and the (not so) happy end of the story is the Unicode standard. Unicode assigns a number, known as code point, to each character of each known alphabet. Unicode as a standard does not limit a character representation to a two-byte system (65536 characters). Although this is a common belief, it is just not true. How many bytes a character may occupy it depends on the Encoding used.

##### Encodings

Unicode uses encodings to map characters to numbers (code-points). As Joel Spolsky says: "It does not make sense to have a string without knowing what encoding it uses". The UTF-16 (UTF stands for Unicode Transformation Format), uses two bytes for the most of the characters it encodes, while UTF-32 uses four bytes. There is a UTF-8 and a UTF-7 Encoding too. All those Encodings, UTF 7, 8, 16, and 32 can represent any character correctly.

Please read Joel Spolsky's excellent article regarding text, character sets, code pages, unicode, encodings, etc at http://www.joelonsoftware.com/articles/Unicode.html. It's a must.

see also:

*   [http://www.joelonsoftware.com/articles/Unicode.html](   http://www.joelonsoftware.com/articles/Unicode.html)
*   [http://www.unicode.org/](http://www.unicode.org/)
*   [http://www.i18nguy.com/unicode/codepages.html](http://www.i18nguy.com/unicode/codepages.html)
*   [http://msdn.microsoft.com/el-gr/goglobal/cc305158(en-us).aspx](http://msdn.microsoft.com/el-gr/goglobal/cc305158(en-us).aspx)
*   [http://msdn.microsoft.com/el-gr/goglobal/cc305146(en-us).aspx](http://msdn.microsoft.com/el-gr/goglobal/cc305146(en-us).aspx)

#### Encoding class

FCL provides the System.Text.Encoding class. Here is the Encoding class declaration.

    public abstract class Encoding : ICloneable
    {
        public static Encoding ASCII { get; }
        public static Encoding BigEndianUnicode { get; }
        public virtual string BodyName { get; }
        public virtual int CodePage { get; }
        public DecoderFallback DecoderFallback { get; set; }
        public static Encoding Default { get; }
        public EncoderFallback EncoderFallback { get; set; }
        public virtual string EncodingName { get; }
        public virtual string HeaderName { get; }
        public virtual bool IsBrowserDisplay { get; }
        public virtual bool IsBrowserSave { get; }
        public virtual bool IsMailNewsDisplay { get; }
        public virtual bool IsMailNewsSave { get; }
        public bool IsReadOnly { get; }
        public virtual bool IsSingleByte { get; }
        public static Encoding Unicode { get; }
        public static Encoding UTF32 { get; }
        public static Encoding UTF7 { get; }
        public static Encoding UTF8 { get; }
        public virtual string WebName { get; }
        public virtual int WindowsCodePage { get; }

        public virtual object Clone();
        public static byte[] Convert(Encoding srcEncoding, Encoding dstEncoding, byte[] bytes);
        public static byte[] Convert(Encoding srcEncoding, Encoding dstEncoding, byte[] bytes, int index, int count);
        public override bool Equals(object value);
        public virtual int GetByteCount(char[] chars);
        public virtual int GetByteCount(string s);
        public virtual int GetByteCount(char* chars, int count);
        public abstract int GetByteCount(char[] chars, int index, int count);
        public virtual byte[] GetBytes(char[] chars);
        public virtual byte[] GetBytes(string s);
        public virtual byte[] GetBytes(char[] chars, int index, int count);
        public virtual int GetBytes(char chars, int charCount, byte* bytes, int byteCount);
        public abstract int GetBytes(char[] chars, int charIndex, int charCount, byte[] bytes, int byteIndex);
        public virtual int GetBytes(string s, int charIndex, int charCount, byte[] bytes, int byteIndex);
        public virtual int GetCharCount(byte[] bytes);
        public virtual int GetCharCount(byte* bytes, int count);
        public abstract int GetCharCount(byte[] bytes, int index, int count);
        public virtual char[] GetChars(byte[] bytes);
        public virtual char[] GetChars(byte[] bytes, int index, int count);
        public virtual int GetChars(byte* bytes, int byteCount, char* chars, int charCount);
        public abstract int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex);
        public virtual Decoder GetDecoder();
        public virtual Encoder GetEncoder();
        public static Encoding GetEncoding(int codepage);
        public static Encoding GetEncoding(string name);
        public static Encoding GetEncoding(int codepage, EncoderFallback encoderFallback, DecoderFallback decoderFallback);
        public static Encoding GetEncoding(string name, EncoderFallback encoderFallback, DecoderFallback decoderFallback);
        public static EncodingInfo[] GetEncodings();
        public override int GetHashCode();
        public abstract int GetMaxByteCount(int charCount);
        public abstract int GetMaxCharCount(int byteCount);
        public virtual byte[] GetPreamble();
        public virtual string GetString(byte[] bytes);
        public virtual string GetString(byte[] bytes, int index, int count);
        public bool IsAlwaysNormalized();
        public virtual bool IsAlwaysNormalized(NormalizationForm form);
    }
    

The Encoding class has the following descendants.

*   ASCIIEncoding
*   UnicodeEncoding
*   UTF7Encoding
*   UTF8Encoding
*   UTF32Encoding

Also, in an effort to support legacy systems, it is possible to create an Encoding instance for most of the character sets and the code pages of the past. The Encoding class documentation provides a full list of the supported code pages.

Here is an example

    Encoding enc = Encoding.GetEncoding("windows-1253");
    MessageBox.Show(enc.EncodingName);
    MessageBox.Show(enc.GetType().FullName);
    

##### Encoding and decoding operations

An encoding operation transforms text data of a certain encoding to an array of bytes. A decoding operation transforms an array of bytes of a certain encoding to text data. An Encoding class specifies the rules of an encoding or decoding operation.

The Encoding.GetBytes() method

    public virtual byte[] GetBytes(string s);
    public virtual byte[] GetBytes(char[] chars);    
    public virtual byte[] GetBytes(char[] chars, int index, int count);
    

encodes a string to an array of bytes. The Encoding.Convert() method

    public static byte[] Convert(Encoding srcEncoding, Encoding dstEncoding, byte[] bytes);
    public static byte[] Convert(Encoding srcEncoding, Encoding dstEncoding, byte[] bytes, int index, int count);
    

converts that byte array from one Encoding to another. The Encoding.GetString() method

    public virtual string GetString(byte[] bytes);
    public virtual string GetString(byte[] bytes, int index, int count);
    

decodes a byte array to a string.

Here is an example.

    Encoding SourceEnc = Encoding.Unicode;
    Encoding DestEnc = Encoding.GetEncoding("windows-1253");

    string SourceString = "test string";
    byte[] SourceBytes = SourceEnc.GetBytes(SourceString);
    byte[] DestBytes = Encoding.Convert(SourceEnc, DestEnc, SourceBytes);
    string DestString = DestEnc.GetString(DestBytes);

    MessageBox.Show(DestString);

#### About CLR strings and characters

CRL provides the System.Char structure and the System.String class to represent a character and a string. The content of a Char and a String is encoded using the UTF-16 encoding (UnicodeEncoding class) which represents each code point as a sequence of one or two 16-bit integers. So assuming that a Char value is always two bytes is a mistake.

The above means that CRL strings are Unicode utf-16 encoded strings.

#### TextInfo class

CultureInfo class provides the TextInfo property

    public virtual TextInfo TextInfo { get; }
    

of type System.Globalization.TextInfo class. Here is the class declaration

    public class TextInfo : ICloneable, IDeserializationCallback
    {
        public virtual int ANSICodePage { get; }
        public string CultureName { get; }
        public virtual int EBCDICCodePage { get; }
        public bool IsReadOnly { get; }
        public bool IsRightToLeft { get; }
        public int LCID { get; }
        public virtual string ListSeparator { get; set; }
        public virtual int MacCodePage { get; }
        public virtual int OEMCodePage { get; }

        public virtual object Clone();
        public override bool Equals(object obj);
        public override int GetHashCode();
        public static TextInfo ReadOnly(TextInfo textInfo);
        public virtual char ToLower(char c);
        public virtual string ToLower(string str);
        public override string ToString();
        public string ToTitleCase(string str);
        public virtual char ToUpper(char c);
        public virtual string ToUpper(string str);
    }

TextInfo represents the writing system of a culture. It provides a group of informational read-only properties and methods for casing that are specific to that writing system.

    string S = "this is a sample text";

    string S2 = Application.CurrentCulture.TextInfo.ToTitleCase(S) + Environment.NewLine +
                Application.CurrentCulture.TextInfo.ToLower(S) + Environment.NewLine +
                Application.CurrentCulture.TextInfo.ToUpper(S);

    MessageBox.Show(S2);
    

#### String comparison

CultureInfo class provides the CompareInfo property

    public virtual CompareInfo CompareInfo { get; }

of type System.Globalization.CompareInfo class. Here is the class declaration.

    public class CompareInfo : IDeserializationCallback
    {
        public int LCID { get; }
        public virtual string Name { get; }

        public virtual int Compare(string string1, string string2);
        public virtual int Compare(string string1, string string2, CompareOptions options);
        public virtual int Compare(string string1, int offset1, string string2, int offset2);
        public virtual int Compare(string string1, int offset1, string string2, int offset2, CompareOptions options);
        public virtual int Compare(string string1, int offset1, int length1, string string2, int offset2, int length2);
        public virtual int Compare(string string1, int offset1, int length1, string string2, int offset2, int length2, CompareOptions options);
        public override bool Equals(object value);
        public static CompareInfo GetCompareInfo(int culture);
        public static CompareInfo GetCompareInfo(string name);
        public static CompareInfo GetCompareInfo(int culture, Assembly assembly);
        public static CompareInfo GetCompareInfo(string name, Assembly assembly);
        public override int GetHashCode();
        public virtual SortKey GetSortKey(string source);
        public virtual SortKey GetSortKey(string source, CompareOptions options);
        public virtual int IndexOf(string source, char value);
        public virtual int IndexOf(string source, string value);
        public virtual int IndexOf(string source, char value, CompareOptions options);
        public virtual int IndexOf(string source, char value, int startIndex);
        public virtual int IndexOf(string source, string value, CompareOptions options);
        public virtual int IndexOf(string source, string value, int startIndex);
        public virtual int IndexOf(string source, char value, int startIndex, CompareOptions options);
        public virtual int IndexOf(string source, char value, int startIndex, int count);
        public virtual int IndexOf(string source, string value, int startIndex, CompareOptions options);
        public virtual int IndexOf(string source, string value, int startIndex, int count);
        public virtual int IndexOf(string source, char value, int startIndex, int count, CompareOptions options);
        public virtual int IndexOf(string source, string value, int startIndex, int count, CompareOptions options);
        public virtual bool IsPrefix(string source, string prefix);
        public virtual bool IsPrefix(string source, string prefix, CompareOptions options);
        public static bool IsSortable(char ch);
        public static bool IsSortable(string text);
        public virtual bool IsSuffix(string source, string suffix);
        public virtual bool IsSuffix(string source, string suffix, CompareOptions options);
        public virtual int LastIndexOf(string source, char value);
        public virtual int LastIndexOf(string source, string value);
        public virtual int LastIndexOf(string source, char value, CompareOptions options);
        public virtual int LastIndexOf(string source, char value, int startIndex);
        public virtual int LastIndexOf(string source, string value, CompareOptions options);
        public virtual int LastIndexOf(string source, string value, int startIndex);
        public virtual int LastIndexOf(string source, char value, int startIndex, CompareOptions options);
        public virtual int LastIndexOf(string source, char value, int startIndex, int count);
        public virtual int LastIndexOf(string source, string value, int startIndex, CompareOptions options);
        public virtual int LastIndexOf(string source, string value, int startIndex, int count);
        public virtual int LastIndexOf(string source, char value, int startIndex, int count, CompareOptions options);
        public virtual int LastIndexOf(string source, string value, int startIndex, int count, CompareOptions options);
        public override string ToString();
    }

CompareInfo is a set of methods for culture-sensitive string comparisons.

##### Comparison operations use the culture of the current thread

Comparison operations use the culture of the current thread, unless specified otherwise.

This means that Sting.Compare() methods

    public sealed class String : IComparable, ICloneable, IConvertible, IComparable<string>, IEnumerable<char>, IEnumerable, IEquatable<string>
    {
        ...
        
        public static int Compare(string strA, string strB);
        public static int Compare(string strA, string strB, bool ignoreCase);
        public static int Compare(string strA, string strB, StringComparison comparisonType);
        public static int Compare(string strA, string strB, bool ignoreCase, CultureInfo culture);
        public static int Compare(string strA, string strB, CultureInfo culture, CompareOptions options);
        public static int Compare(string strA, int indexA, string strB, int indexB, int length);
        public static int Compare(string strA, int indexA, string strB, int indexB, int length, bool ignoreCase);
        public static int Compare(string strA, int indexA, string strB, int indexB, int length, StringComparison comparisonType);
        public static int Compare(string strA, int indexA, string strB, int indexB, int length, bool ignoreCase, CultureInfo culture);
        public static int Compare(string strA, int indexA, string strB, int indexB, int length, CultureInfo culture, CompareOptions options);
 
        ...
    }

that do not explicitly get a CultureInfo argument, they use the CultureInfo of the current thread.

An application performs a culture-sensitive comparison when a sort operation

*   depends on a particular culture
*   must be performed using the invariant culture.

##### Three different ways of comparing and sorting strings

The CompareOptions enum defines a set of possible options for string comparisons.

    [FlagsAttribute]
    public enum CompareOptions
    {
        None = 0,
        IgnoreCase = 1,
        IgnoreNonSpace = 2,
        IgnoreSymbols = 4,
        IgnoreKanaType = 8,
        IgnoreWidth = 16,
        OrdinalIgnoreCase = 268435456,
        StringSort = 536870912,
        Ordinal = 1073741824,
    }
  
  

CLR may use one of three different ways when comparing or sorting strings:

*   word sort
*   string sort
*   ordinal sort.

Word sort performs culture-sensitive string comparison, taking into account the special weights some non-alphanumeric characters, such as the hyphen ("-"), may have.

String sort performs culture-sensitive string comparison too. Non-alphanumeric characters come before all alphanumeric characters.

Ordinal sort performs string comparison based on the Unicode value of each character in a string.

#### NumberFormatInfo class

CultureInfo class provides the NumberFormat property

    public virtual NumberFormatInfo NumberFormat { get; set; }

of type System.Globalization.NumberFormatInfo class. Here is the class declaration.

    public sealed class NumberFormatInfo : ICloneable, IFormatProvider
    {
        public NumberFormatInfo();

        public int CurrencyDecimalDigits { get; set; }
        public string CurrencyDecimalSeparator { get; set; }
        public string CurrencyGroupSeparator { get; set; }
        public int[] CurrencyGroupSizes { get; set; }
        public int CurrencyNegativePattern { get; set; }
        public int CurrencyPositivePattern { get; set; }
        public string CurrencySymbol { get; set; }
        public static NumberFormatInfo CurrentInfo { get; }
        public DigitShapes DigitSubstitution { get; set; }
        public static NumberFormatInfo InvariantInfo { get; }
        public bool IsReadOnly { get; }
        public string NaNSymbol { get; set; }
        public string[] NativeDigits { get; set; }
        public string NegativeInfinitySymbol { get; set; }
        public string NegativeSign { get; set; }
        public int NumberDecimalDigits { get; set; }
        public string NumberDecimalSeparator { get; set; }
        public string NumberGroupSeparator { get; set; }
        public int[] NumberGroupSizes { get; set; }
        public int NumberNegativePattern { get; set; }
        public int PercentDecimalDigits { get; set; }
        public string PercentDecimalSeparator { get; set; }
        public string PercentGroupSeparator { get; set; }
        public int[] PercentGroupSizes { get; set; }
        public int PercentNegativePattern { get; set; }
        public int PercentPositivePattern { get; set; }
        public string PercentSymbol { get; set; }
        public string PerMilleSymbol { get; set; }
        public string PositiveInfinitySymbol { get; set; }
        public string PositiveSign { get; set; }

        public object Clone();
        public object GetFormat(Type formatType);
        public static NumberFormatInfo GetInstance(IFormatProvider formatProvider);
        public static NumberFormatInfo ReadOnly(NumberFormatInfo nfi);
    }

The NumberFormatInfo class provides information, such as the CurrencySymbol, the NumberDecimalSeparator etc.

It is not possible to create a NumberFormatInfo object for a neutral culture. To create a NumberFormatInfo object for a specific culture, an application it first creates the CultureInfo object and then retrieves the NumberFormat property.

NumberFormatInfo class implements the IFormatProvider interface. Thus a NumberFormatInfo instance can be passed to various ToString() and Parse() methods that require an IFormatProvider object. The System.Int32, the int type, for example, provides the following ToString() and Parse() overloads.

    public string ToString(IFormatProvider provider);
    public string ToString(string format, IFormatProvider provider);        
    
    public static int Parse(string s, IFormatProvider provider);
    public static int Parse(string s, NumberStyles style, IFormatProvider provider);    
        

#### DateTimeFormatInfo class

CultureInfo class provides the DateTimeFormat property

    public virtual DateTimeFormatInfo DateTimeFormat { get; set; }

of type System.Globalization.DateTimeFormatInfo class. Here is the class declaration.

    public sealed class DateTimeFormatInfo : ICloneable, IFormatProvider
    {
        public DateTimeFormatInfo();

        public string[] AbbreviatedDayNames { get; set; }
        public string[] AbbreviatedMonthGenitiveNames { get; set; }
        public string[] AbbreviatedMonthNames { get; set; }
        public string AMDesignator { get; set; }
        public Calendar Calendar { get; set; }
        public CalendarWeekRule CalendarWeekRule { get; set; }
        public static DateTimeFormatInfo CurrentInfo { get; }
        public string DateSeparator { get; set; }
        public string[] DayNames { get; set; }
        public DayOfWeek FirstDayOfWeek { get; set; }
        public string FullDateTimePattern { get; set; }
        public static DateTimeFormatInfo InvariantInfo { get; }
        public bool IsReadOnly { get; }
        public string LongDatePattern { get; set; }
        public string LongTimePattern { get; set; }
        public string MonthDayPattern { get; set; }
        public string[] MonthGenitiveNames { get; set; }
        public string[] MonthNames { get; set; }
        public string NativeCalendarName { get; }
        public string PMDesignator { get; set; }
        public string RFC1123Pattern { get; }
        public string ShortDatePattern { get; set; }
        public string[] ShortestDayNames { get; set; }
        public string ShortTimePattern { get; set; }
        public string SortableDateTimePattern { get; }
        public string TimeSeparator { get; set; }
        public string UniversalSortableDateTimePattern { get; }
        public string YearMonthPattern { get; set; }

        public object Clone();
        public string GetAbbreviatedDayName(DayOfWeek dayofweek);
        public string GetAbbreviatedEraName(int era);
        public string GetAbbreviatedMonthName(int month);
        public string[] GetAllDateTimePatterns();
        public string[] GetAllDateTimePatterns(char format);
        public string GetDayName(DayOfWeek dayofweek);
        public int GetEra(string eraName);
        public string GetEraName(int era);
        public object GetFormat(Type formatType);
        public static DateTimeFormatInfo GetInstance(IFormatProvider provider);
        public string GetMonthName(int month);
        public string GetShortestDayName(DayOfWeek dayOfWeek);
        public static DateTimeFormatInfo ReadOnly(DateTimeFormatInfo dtfi);
        public void SetAllDateTimePatterns(string[] patterns, char format);
    }

The DateTimeFormatInfo class provides information, such as the Calendar, the DateSeparator etc.

It is not possible to create a DateTimeFormatInfo object for a neutral culture. To create a DateTimeFormatInfo object for a specific culture, an application it first creates the CultureInfo object and then retrieves the DateTimeFormat property.

DateTimeFormatInfo class implements the IFormatProvider interface. Thus a DateTimeFormatInfo instance can be passed to various ToString() and Parse() overloaded methods of the DateTime struct that require an IFormatProvider object.

    public string ToString(IFormatProvider provider);
    public string ToString(string format, IFormatProvider provider);

    public static DateTime Parse(string s, IFormatProvider provider);
    public static DateTime Parse(string s, IFormatProvider provider, DateTimeStyles styles);

#### Calendar class

CultureInfo class provides the Calendar property

    public virtual Calendar Calendar { get; }

of type System.Globalization.Calendar class. Here is the class declaration.

    public abstract class Calendar : ICloneable
    {
        public const int CurrentEra = 0;

        public virtual CalendarAlgorithmType AlgorithmType { get; }
        public abstract int[] Eras { get; }
        public bool IsReadOnly { get; }
        public virtual DateTime MaxSupportedDateTime { get; }
        public virtual DateTime MinSupportedDateTime { get; }
        public virtual int TwoDigitYearMax { get; set; }

        public virtual DateTime AddDays(DateTime time, int days);
        public virtual DateTime AddHours(DateTime time, int hours);
        public virtual DateTime AddMilliseconds(DateTime time, double milliseconds);
        public virtual DateTime AddMinutes(DateTime time, int minutes);
        public abstract DateTime AddMonths(DateTime time, int months);
        public virtual DateTime AddSeconds(DateTime time, int seconds);
        public virtual DateTime AddWeeks(DateTime time, int weeks);
        public abstract DateTime AddYears(DateTime time, int years);
        public virtual object Clone();
        public abstract int GetDayOfMonth(DateTime time);
        public abstract DayOfWeek GetDayOfWeek(DateTime time);
        public abstract int GetDayOfYear(DateTime time);
        public virtual int GetDaysInMonth(int year, int month);
        public abstract int GetDaysInMonth(int year, int month, int era);
        public virtual int GetDaysInYear(int year);
        public abstract int GetDaysInYear(int year, int era);
        public abstract int GetEra(DateTime time);
        public virtual int GetHour(DateTime time);
        public virtual int GetLeapMonth(int year);
        public virtual int GetLeapMonth(int year, int era);
        public virtual double GetMilliseconds(DateTime time);
        public virtual int GetMinute(DateTime time);
        public abstract int GetMonth(DateTime time);
        public virtual int GetMonthsInYear(int year);
        public abstract int GetMonthsInYear(int year, int era);
        public virtual int GetSecond(DateTime time);
        public virtual int GetWeekOfYear(DateTime time, CalendarWeekRule rule, DayOfWeek firstDayOfWeek);
        public abstract int GetYear(DateTime time);
        public virtual bool IsLeapDay(int year, int month, int day);
        public abstract bool IsLeapDay(int year, int month, int day, int era);
        public virtual bool IsLeapMonth(int year, int month);
        public abstract bool IsLeapMonth(int year, int month, int era);
        public virtual bool IsLeapYear(int year);
        public abstract bool IsLeapYear(int year, int era);
        public static Calendar ReadOnly(Calendar calendar);
        public virtual DateTime ToDateTime(int year, int month, int day, int hour, int minute, int second, int millisecond);
        public abstract DateTime ToDateTime(int year, int month, int day, int hour, int minute, int second, int millisecond, int era);
        public virtual int ToFourDigitYear(int year);
    }
    

The Calendar class has the following descendants:

*   EastAsianLunisolarCalendar
*   GregorianCalendar
*   HebrewCalendar
*   HijriCalendar
*   JapaneseCalendar
*   PersianCalendar
*   JulianCalendar
*   KoreanCalendar
*   TaiwanCalendar
*   ThaiBuddhistCalendar
*   UmAlQuraCalendar

A Calendar object represents the calendar of a certain culture. It divides time into weeks, months and years.

The DateTime struct provides contructors that accept a Calendar value. The default calendar the DateTime uses is the gregorian calendar.

##### Other classes related to date and time

The FCL provides a set of date and time related classes.

*   DateTimeOffset class
*   TimeZoneInfo class
*   DaylightTime class
*   DaylightTime class
*   DateTimeStyles Enumeration

### Localization: making a multi-lingual application

Localization is the translation of, mostly string, resources to a specific language and culture.

The main assembly of an application (or library) contains application code and resources, such as strings and images. Resources contained in the main assembly are for the language in which the application is originally developed and they are known as "fallback" resources.

Along with the main assembly there may be one or more satellite assemblies, one for each supported language. Satellite assemblies contain the localized resources only and no code at all.

Satellite (localized) assemblies are placed in folders under the root application folder. Here is such a folder tree.

    AppName
        en
        en-GB
        de
        fr-FR
        fr-CA 

AppName is the root application folder, where the executable resides. Lets say that this application is developed in greek language. Thus the fall-back resources contained in the main assembly are in greek language.

The en folder contains resources for the english language that are independent of any english speaking country or region. The en-GB folder contains country/region specific resources for the United Kingdom. This is because there maybe words or phrases that require a slightly different translation or spelling. (the word color and colour for example).

The de folder contains country/region independent resources for the german language. The fr-FR and fr-CA folders contain country/region specific resources for the french language and for the France and Canada respectively.

Sattelite assemblies are named as

    OriginalAssemblyName.resources.dll

Supposing that the AppName application consists of the following assemblies

    MyApp.exe
    MyLib.dll
    

then each of those localized resource folders may contain

    MyApp.resources.dll
    MyLib.resources.dll
 

The ResourceManager class locates resources in a hierarchical manner. It starts looking for a directory with the name of the current UI culture and then falls back looking for parents etc. If the resouce is not found then it ultimately falls back to the resources in the main assembly.

MS Visual Studio can generate resource files for both the fall-back and the additional languages required. Those resource files are in the .resx format, which is the xml-based resource format. They are compiled to an intermediate binary format as XXXX.resources files and finally they are embedded in satellite assemblies. The whole process is done automatically by the building system. The fall-back resources are built into the main assembly. The resource files for any additional language are built into separate satellite assemblies, one for each language/culture.

NOTE: Resource files can be also processed by the Resource File Generator (Resgen.exe) tool. See online help for more information.

#### Localizing a form

At design-time only, a Form provides the Localizable and Language pseudo-properties. By default Localizable is set to false and Language to (Default). Here are the steps required to localize a form

*   set Localizable to true
*   place and arrange controls on the form
*   set Language property to the desired language
*   translate button, label, menu etc. text to that language.
*   it is also valid to resize controls in order to accomodate the translated text
*   repeat the c of setting the Language and translating for any language required.

A new .resx file is created for each Language the user translates the form. That .resx file is placed at the same node as the form and it is named as

    <FormName>.<CultureName>.resx
    

for example

    MyForm.en-GB.resx
    

Double clicking on that .resx file presents the Resource Designer where the user can edit the resource strings.

Changing the Language property of the form back to (Default) restores the original text and the size of any control. That means that the resource system stores information not only regarding the text of a control but its position and size as well, in respect to the current Language.

After building the project, the .resources files are placed in the

    \obj\Debug
    

folder, while the .resources.dll satellite assemblies are placed in the

    \bin\Debug
    

folder, inside their language/culture specific sub-folder.

#### Localizing general string resources

As the Application resources section of this text describes, when the user creates a new Windows Forms project with the MS Visual Studio, the IDE adds a Property folder to the project. That Property folder contains a Resources.resx node. That Resources.resx node is actually a disk file in that folder with that same name, and is where general string resouces, such as text messages, error messages etc., for the (Default) language, should be placed.

Here are the steps required to add a localized version of this resource file.

*   Solution Explorer | (right click on) Project | Add | New Item | Resources File
*   Name the new resources file as Resources.<CultureName>.resx (i.e. Resources.en-GB.resx)
*   Place the file inside the Properties folder of the Project.
*   repeat the steps of adding and placing a resources file for any language required.

Double clicking on such a resource file presents the Resource Designer for that file. Add string resource items to that file using the Resource Designer. Each string resource item must have the same Name as the corresponding item in the original Resources.resx.

After building the project, the resource items of a localized resource .resx file, as with Forms, are placed into the XXXX.resources.dll at a language/culture specific sub-folder.

#### Setting application culture

A culture setting can come from a command line argument (possibly a Windows shortcut), a configuration file with user preferences etc, a database setting or a menu item or a command button click at run-time.

At run-time setting just the CurrentUICulture of the current thread has not any immediate effect, since the form is already loaded. Here is a way to set the CurrentUICulture and at the same time, reload the form.

    void ChangeCulture(string Culture)
    {
        Thread.CurrentThread.CurrentUICulture = new CultureInfo(Culture);
        Thread.CurrentThread.CurrentCulture = new CultureInfo(Culture);

        if (this.components != null)
            this.components.Dispose();

        this.Controls.Clear();
        this.InitializeComponent();
    }

Reloading the form, refreshes the user interface by forcing ResourceManager to look for string resources in a different localized resource.

#### Localization tools

For the programmer the primary localization tool is the MS Visual IDE itself. Setting the Language property of a form to a desired language and then translating captions and texts or adding a new Resources.<CultureName>.resx file to the project and then inserting the appropriate records to it, is a way to see immediate results, although not an easy one, especially with large projects.

.Net comes with the Windows Forms Resource Editor (Winres.exe) which is a localization tool and works with .resx or .resources files.

Searching web for "Localization tools" reveals many tools for localizing Windows Forms applications.

see also:

*   [http://www.sdl.com](   http://www.sdl.com)
*   [http://www.sisulizer.com/](http://www.sisulizer.com/)
*   [http://www.lingobit.com/](http://www.lingobit.com/)

#### 

* * *

###### Copyright � 2009 Theodoros Bebekis, Thessaloniki, Greece (teo point bebekis at gmail point com)