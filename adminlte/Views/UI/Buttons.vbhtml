@Code       
    ViewBag.Title = "Buttons"
    Layout = "~/Views/Shared/_Layout.vbhtml"
End Code

<!-- Content Wrapper. Contains page content -->
<div Class="content-wrapper">
    <!-- Content Header (Page header) -->
    <section Class="content-header">
        <h1>
            Buttons
            <small> Control panel</small>
        </h1>
        <ol Class="breadcrumb">
            <li> <a href = "#" <> i Class="fa fa-dashboard"></i> Home</a></li>
            <li> <a href = "#" > UI</a></li>
            <li Class="active">Buttons</li>
        </ol>
    </section>
    <!-- Main content -->
    <section Class="content">
        <div Class="row">
            <div Class="col-md-12">
                <div Class="box box-primary">
                    <div Class="box-header">
                        <i Class="fa fa-edit"></i>
                        <h3 Class="box-title">Buttons</h3>
                    </div>
                    <div Class="box-body pad table-responsive">
                        <p> Various types Of buttons. Using the base Class <code>.btn</code></p>
                        <table Class="table table-bordered text-center">
                            <tr>
                                                        <th> Normal</th>
                                <th> Large <code>.btn-lg</code></th>
                                <th> Small <code>.btn-sm</code></th>
                                <th> X-Small <code>.btn-xs</code></th>
                                <th> Flat <code>.btn-flat</code></th>
                                <th> Disabled <code>.disabled</code></th>
                            </tr>
                            <tr>
                                                        <td>
                                                        <button type = "button" Class="btn btn-block btn-default">Default</button>
                                </td>
                                <td>
                                                        <button type = "button" Class="btn btn-block btn-default btn-lg">Default</button>
                                </td>
                                <td>
                                                        <button type = "button" Class="btn btn-block btn-default btn-sm">Default</button>
                                </td>
                                <td>
                                                        <button type = "button" Class="btn btn-block btn-default btn-xs">Default</button>
                                </td>
                                <td>
                                                        <button type = "button" Class="btn btn-block btn-default btn-flat">Default</button>
                                </td>
                                <td>
                                                        <button type = "button" Class="btn btn-block btn-default disabled">Default</button>
                                </td>
                            </tr>
                            <tr>
                                                        <td>
                                                        <button type = "button" Class="btn btn-block btn-primary">Primary</button>
                                </td>
                                <td>
                                                        <button type = "button" Class="btn btn-block btn-primary btn-lg">Primary</button>
                                </td>
                                <td>
                                                        <button type = "button" Class="btn btn-block btn-primary btn-sm">Primary</button>
                                </td>
                                <td>
                                                        <button type = "button" Class="btn btn-block btn-primary btn-xs">Primary</button>
                                </td>
                                <td>
                                                        <button type = "button" Class="btn btn-block btn-primary btn-flat">Primary</button>
                                </td>
                                <td>
                                                        <button type = "button" Class="btn btn-block btn-primary disabled">Primary</button>
                                </td>
                            </tr>
                            <tr>
                                                        <td>
                                                        <button type = "button" Class="btn btn-block btn-success">Success</button>
                                </td>
                                <td>
                                                        <button type = "button" Class="btn btn-block btn-success btn-lg">Success</button>
                                </td>
                                <td>
                                                        <button type = "button" Class="btn btn-block btn-success btn-sm">Success</button>
                                </td>
                                <td>
                                                        <button type = "button" Class="btn btn-block btn-success btn-xs">Success</button>
                                </td>
                                <td>
                                                        <button type = "button" Class="btn btn-block btn-success btn-flat">Success</button>
                                </td>
                                <td>
                                                        <button type = "button" Class="btn btn-block btn-success disabled">Success</button>
                                </td>
                            </tr>
                            <tr>
                                                        <td>
                                                        <button type = "button" Class="btn btn-block btn-info">Info</button>
                                </td>
                                <td>
                                                        <button type = "button" Class="btn btn-block btn-info btn-lg">Info</button>
                                </td>
                                <td>
                                                        <button type = "button" Class="btn btn-block btn-info btn-sm">Info</button>
                                </td>
                                <td>
                                                        <button type = "button" Class="btn btn-block btn-info btn-xs">Info</button>
                                </td>
                                <td>
                                                        <button type = "button" Class="btn btn-block btn-info btn-flat">Info</button>
                                </td>
                                <td>
                                                        <button type = "button" Class="btn btn-block btn-info disabled">Info</button>
                                </td>
                            </tr>
                            <tr>
                                                        <td>
                                                        <button type = "button" Class="btn btn-block btn-danger">Danger</button>
                                </td>
                                <td>
                                                        <button type = "button" Class="btn btn-block btn-danger btn-lg">Danger</button>
                                </td>
                                <td>
                                                        <button type = "button" Class="btn btn-block btn-danger btn-sm">Danger</button>
                                </td>
                                <td>
                                                        <button type = "button" Class="btn btn-block btn-danger btn-xs">Danger</button>
                                </td>
                                <td>
                                                        <button type = "button" Class="btn btn-block btn-danger btn-flat">Danger</button>
                                </td>
                                <td>
                                                        <button type = "button" Class="btn btn-block btn-danger disabled">Danger</button>
                                </td>
                            </tr>
                            <tr>
                                                        <td>
                                                        <button type = "button" Class="btn btn-block btn-warning">Warning</button>
                                </td>
                                <td>
                                                        <button type = "button" Class="btn btn-block btn-warning btn-lg">Warning</button>
                                </td>
                                <td>
                                                        <button type = "button" Class="btn btn-block btn-warning btn-sm">Warning</button>
                                </td>
                                <td>
                                                        <button type = "button" Class="btn btn-block btn-warning btn-xs">Warning</button>
                                </td>
                                <td>
                                                        <button type = "button" Class="btn btn-block btn-warning btn-flat">Warning</button>
                                </td>
                                <td>
                                                        <button type = "button" Class="btn btn-block btn-warning disabled">Warning</button>
                                </td>
                            </tr>
                        </table>
                    </div>
                    <!-- /.box -->
                </div>
            </div>
            <!-- /.col -->
        </div>
        <!-- ./row -->
        <div Class="row">
            <div Class="col-md-6">
                <!-- Block buttons -->
                <div Class="box">
                    <div Class="box-header">
                        <h3 Class="box-title">Block Buttons</h3>
                    </div>
                    <div Class="box-body">
                        <button type = "button" Class="btn btn-default btn-block">.btn-block</button>
                        <button type = "button" Class="btn btn-default btn-block btn-flat">.btn-block .btn-flat</button>
                        <button type = "button" Class="btn btn-default btn-block btn-sm">.btn-block .btn-sm</button>
                    </div>
                </div>
                <!-- /.box -->
                <!-- Horizontal grouping -->
                <div Class="box">
                    <div Class="box-header">
                        <h3 Class="box-title">Horizontal Button Group</h3>
                    </div>
                    <div Class="box-body table-responsive pad">
                        <p>
                                                                                                Horizontal button groups are easy To create With bootstrap. Just add your buttons
                            inside <code>&lt;div class="btn-group"&gt;&lt;/div&gt;</code>
                        </p>
                        <table Class="table table-bordered">
                            <tr>
                                                                                                    <th> Button</th>
                                <th> Icons</th>
                                <th> Flat</th>
                                <th> Dropdown</th>
                            </tr>
                            <!-- Default -->
                            <tr>
                                                                                                    <td>
                                                                                                    <div Class="btn-group">
                                        <button type = "button" Class="btn btn-default">Left</button>
                                        <button type = "button" Class="btn btn-default">Middle</button>
                                        <button type = "button" Class="btn btn-default">Right</button>
                                    </div>
                                </td>
                                <td>
                                                                                                        <div Class="btn-group">
                                        <button type = "button" Class="btn btn-default"><i Class="fa fa-align-left"></i></button>
                                        <button type = "button" Class="btn btn-default"><i Class="fa fa-align-center"></i></button>
                                        <button type = "button" Class="btn btn-default"><i Class="fa fa-align-right"></i></button>
                                    </div>
                                </td>
                                <td>
                                                                                                            <div Class="btn-group">
                                        <button type = "button" Class="btn btn-default btn-flat"><i Class="fa fa-align-left"></i></button>
                                        <button type = "button" Class="btn btn-default btn-flat"><i Class="fa fa-align-center"></i></button>
                                        <button type = "button" Class="btn btn-default btn-flat"><i Class="fa fa-align-right"></i></button>
                                    </div>
                                </td>
                                <td>
                                                                                                                <div Class="btn-group">
                                        <button type = "button" Class="btn btn-default">1</button>
                                        <button type = "button" Class="btn btn-default">2</button>
                                        <div Class="btn-group">
                                            <button type = "button" Class="btn btn-default dropdown-toggle" data-toggle="dropdown">
                                                <span Class="caret"></span>
                                            </button>
                                            <ul Class="dropdown-menu">
                                                <li> <a href = "#" > Dropdown link</a></li>
                                                <li> <a href = "#" > Dropdown link</a></li>
                                            </ul>
                                        </div>
                                    </div>
                                </td>
                            </tr>
                            <!-- ./default -->
                            <!-- Info -->
                            <tr>
                                                                                                                                <td>
                                                                                                                                <div Class="btn-group">
                                        <button type = "button" Class="btn btn-info">Left</button>
                                        <button type = "button" Class="btn btn-info">Middle</button>
                                        <button type = "button" Class="btn btn-info">Right</button>
                                    </div>
                                </td>
                                <td>
                                                                                                                                    <div Class="btn-group">
                                        <button type = "button" Class="btn btn-info"><i Class="fa fa-align-left"></i></button>
                                        <button type = "button" Class="btn btn-info"><i Class="fa fa-align-center"></i></button>
                                        <button type = "button" Class="btn btn-info"><i Class="fa fa-align-right"></i></button>
                                    </div>
                                </td>
                                <td>
                                                                                                                                        <div Class="btn-group">
                                        <button type = "button" Class="btn btn-info btn-flat"><i Class="fa fa-align-left"></i></button>
                                        <button type = "button" Class="btn btn-info btn-flat"><i Class="fa fa-align-center"></i></button>
                                        <button type = "button" Class="btn btn-info btn-flat"><i Class="fa fa-align-right"></i></button>
                                    </div>
                                </td>
                                <td>
                                                                                                                                            <div Class="btn-group">
                                        <button type = "button" Class="btn btn-info">1</button>
                                        <button type = "button" Class="btn btn-info">2</button>
                                        <div Class="btn-group">
                                            <button type = "button" Class="btn btn-info dropdown-toggle" data-toggle="dropdown">
                                                <span Class="caret"></span>
                                            </button>
                                            <ul Class="dropdown-menu">
                                                <li> <a href = "#" > Dropdown link</a></li>
                                                <li> <a href = "#" > Dropdown link</a></li>
                                            </ul>
                                        </div>
                                    </div>
                                </td>
                            </tr>
                            <!-- /. info -->
                            <!-- /.danger -->
                            <tr>
                                                                                                                                                            <td>
                                                                                                                                                            <div Class="btn-group">
                                        <button type = "button" Class="btn btn-danger">Left</button>
                                        <button type = "button" Class="btn btn-danger">Middle</button>
                                        <button type = "button" Class="btn btn-danger">Right</button>
                                    </div>
                                </td>
                                <td>
                                                                                                                                                                <div Class="btn-group">
                                        <button type = "button" Class="btn btn-danger"><i Class="fa fa-align-left"></i></button>
                                        <button type = "button" Class="btn btn-danger"><i Class="fa fa-align-center"></i></button>
                                        <button type = "button" Class="btn btn-danger"><i Class="fa fa-align-right"></i></button>
                                    </div>
                                </td>
                                <td>
                                                                                                                                                                    <div Class="btn-group">
                                        <button type = "button" Class="btn btn-danger btn-flat"><i Class="fa fa-align-left"></i></button>
                                        <button type = "button" Class="btn btn-danger btn-flat"><i Class="fa fa-align-center"></i></button>
                                        <button type = "button" Class="btn btn-danger btn-flat"><i Class="fa fa-align-right"></i></button>
                                    </div>
                                </td>
                                <td>
                                                                                                                                                                        <div Class="btn-group">
                                        <button type = "button" Class="btn btn-danger">1</button>
                                        <button type = "button" Class="btn btn-danger">2</button>
                                        <div Class="btn-group">
                                            <button type = "button" Class="btn btn-danger dropdown-toggle" data-toggle="dropdown">
                                                <span Class="caret"></span>
                                            </button>
                                            <ul Class="dropdown-menu">
                                                <li> <a href = "#" > Dropdown link</a></li>
                                                <li> <a href = "#" > Dropdown link</a></li>
                                            </ul>
                                        </div>
                                    </div>
                                </td>
                            </tr>
                            <!-- /.danger -->
                            <!-- warning -->
                            <tr>
                                                                                                                                                                                        <td>
                                                                                                                                                                                        <div Class="btn-group">
                                        <button type = "button" Class="btn btn-warning">Left</button>
                                        <button type = "button" Class="btn btn-warning">Middle</button>
                                        <button type = "button" Class="btn btn-warning">Right</button>
                                    </div>
                                </td>
                                <td>
                                                                                                                                                                                            <div Class="btn-group">
                                        <button type = "button" Class="btn btn-warning"><i Class="fa fa-align-left"></i></button>
                                        <button type = "button" Class="btn btn-warning"><i Class="fa fa-align-center"></i></button>
                                        <button type = "button" Class="btn btn-warning"><i Class="fa fa-align-right"></i></button>
                                    </div>
                                </td>
                                <td>
                                                                                                                                                                                                <div Class="btn-group">
                                        <button type = "button" Class="btn btn-warning btn-flat"><i Class="fa fa-align-left"></i></button>
                                        <button type = "button" Class="btn btn-warning btn-flat"><i Class="fa fa-align-center"></i></button>
                                        <button type = "button" Class="btn btn-warning btn-flat"><i Class="fa fa-align-right"></i></button>
                                    </div>
                                </td>
                                <td>
                                                                                                                                                                                                    <div Class="btn-group">
                                        <button type = "button" Class="btn btn-warning">1</button>
                                        <button type = "button" Class="btn btn-warning">2</button>
                                        <div Class="btn-group">
                                            <button type = "button" Class="btn btn-warning dropdown-toggle" data-toggle="dropdown">
                                                <span Class="caret"></span>
                                            </button>
                                            <ul Class="dropdown-menu">
                                                <li> <a href = "#" > Dropdown link</a></li>
                                                <li> <a href = "#" > Dropdown link</a></li>
                                            </ul>
                                        </div>
                                    </div>
                                </td>
                            </tr>
                            <!-- /.warning -->
                            <!-- success -->
                            <tr>
                                                                                                                                                                                                                    <td>
                                                                                                                                                                                                                    <div Class="btn-group">
                                        <button type = "button" Class="btn btn-success">Left</button>
                                        <button type = "button" Class="btn btn-success">Middle</button>
                                        <button type = "button" Class="btn btn-success">Right</button>
                                    </div>
                                </td>
                                <td>
                                                                                                                                                                                                                        <div Class="btn-group">
                                        <button type = "button" Class="btn btn-success"><i Class="fa fa-align-left"></i></button>
                                        <button type = "button" Class="btn btn-success"><i Class="fa fa-align-center"></i></button>
                                        <button type = "button" Class="btn btn-success"><i Class="fa fa-align-right"></i></button>
                                    </div>
                                </td>
                                <td>
                                                                                                                                                                                                                            <div Class="btn-group">
                                        <button type = "button" Class="btn btn-success btn-flat"><i Class="fa fa-align-left"></i></button>
                                        <button type = "button" Class="btn btn-success btn-flat"><i Class="fa fa-align-center"></i></button>
                                        <button type = "button" Class="btn btn-success btn-flat"><i Class="fa fa-align-right"></i></button>
                                    </div>
                                </td>
                                <td>
                                                                                                                                                                                                                                <div Class="btn-group">
                                        <button type = "button" Class="btn btn-success">1</button>
                                        <button type = "button" Class="btn btn-success">2</button>
                                        <div Class="btn-group">
                                            <button type = "button" Class="btn btn-success dropdown-toggle" data-toggle="dropdown">
                                                <span Class="caret"></span>
                                            </button>
                                            <ul Class="dropdown-menu">
                                                <li> <a href = "#" > Dropdown link</a></li>
                                                <li> <a href = "#" > Dropdown link</a></li>
                                            </ul>
                                        </div>
                                    </div>
                                </td>
                            </tr>
                            <!-- /.success -->
                        </table>
                    </div>
                </div>
                <!-- /.box -->
                <div Class="box">
                    <div Class="box-header">
                        <h3 Class="box-title">Button Addon</h3>
                    </div>
                    <div Class="box-body">
                        <p>With dropdown</p>
                        <div Class="input-group margin">
                            <div Class="input-group-btn">
                                <button type = "button" Class="btn btn-default dropdown-toggle" data-toggle="dropdown">
                                    Action
                                    <span Class="fa fa-caret-down"></span>
                                </button>
                                <ul Class="dropdown-menu">
                                    <li> <a href = "#" > Action</a></li>
                                    <li> <a href = "#" > Another action</a></li>
                                    <li> <a href = "#" > Something Else here</a></li>
                                    <li Class="divider"></li>
                                    <li> <a href = "#" > Separated link</a></li>
                                </ul>
                            </div>
                            <!-- /btn-group -->
                            <input type = "text" Class="form-control">
                        </div>
                        <!-- /input-group -->
                        <p> Normal</p>
                        <div Class="input-group margin">
                            <div Class="input-group-btn">
                                <button type = "button" Class="btn btn-danger">Action</button>
                            </div>
                            <!-- /btn-group -->
                            <input type = "text" Class="form-control">
                        </div>
                        <!-- /input-group -->
                        <p> Flat</p>
                        <div Class="input-group margin">
                            <input type = "text" Class="form-control">
                            <span Class="input-group-btn">
                                <button type = "button" Class="btn btn-info btn-flat">Go!</button>
                            </span>
                        </div>
                        <!-- /input-group -->
                    </div>
                    <!-- /.box-body -->
                </div>
                <!-- /.box -->
                <!-- split buttons box -->
                <div Class="box">
                    <div Class="box-header">
                        <h3 Class="box-title">Split buttons</h3>
                    </div>
                    <div Class="box-body">
                        <!-- Split button -->
                        <p> Normal split buttons:</p>
                        <div Class="margin">
                            <div Class="btn-group">
                                <button type = "button" Class="btn btn-default">Action</button>
                                <button type = "button" Class="btn btn-default dropdown-toggle" data-toggle="dropdown">
                                    <span Class="caret"></span>
                                    <span Class="sr-only">Toggle Dropdown</span>
                                </button>
                                <ul Class="dropdown-menu" role="menu">
                                    <li> <a href = "#" > Action</a></li>
                                    <li> <a href = "#" > Another action</a></li>
                                    <li> <a href = "#" > Something Else here</a></li>
                                    <li Class="divider"></li>
                                    <li> <a href = "#" > Separated link</a></li>
                                </ul>
                            </div>
                            <div Class="btn-group">
                                <button type = "button" Class="btn btn-info">Action</button>
                                <button type = "button" Class="btn btn-info dropdown-toggle" data-toggle="dropdown">
                                    <span Class="caret"></span>
                                    <span Class="sr-only">Toggle Dropdown</span>
                                </button>
                                <ul Class="dropdown-menu" role="menu">
                                    <li> <a href = "#" > Action</a></li>
                                    <li> <a href = "#" > Another action</a></li>
                                    <li> <a href = "#" > Something Else here</a></li>
                                    <li Class="divider"></li>
                                    <li> <a href = "#" > Separated link</a></li>
                                </ul>
                            </div>
                            <div Class="btn-group">
                                <button type = "button" Class="btn btn-danger">Action</button>
                                <button type = "button" Class="btn btn-danger dropdown-toggle" data-toggle="dropdown">
                                    <span Class="caret"></span>
                                    <span Class="sr-only">Toggle Dropdown</span>
                                </button>
                                <ul Class="dropdown-menu" role="menu">
                                    <li> <a href = "#" > Action</a></li>
                                    <li> <a href = "#" > Another action</a></li>
                                    <li> <a href = "#" > Something Else here</a></li>
                                    <li Class="divider"></li>
                                    <li> <a href = "#" > Separated link</a></li>
                                </ul>
                            </div>
                            <div Class="btn-group">
                                <button type = "button" Class="btn btn-success">Action</button>
                                <button type = "button" Class="btn btn-success dropdown-toggle" data-toggle="dropdown">
                                    <span Class="caret"></span>
                                    <span Class="sr-only">Toggle Dropdown</span>
                                </button>
                                <ul Class="dropdown-menu" role="menu">
                                    <li> <a href = "#" > Action</a></li>
                                    <li> <a href = "#" > Another action</a></li>
                                    <li> <a href = "#" > Something Else here</a></li>
                                    <li Class="divider"></li>
                                    <li> <a href = "#" > Separated link</a></li>
                                </ul>
                            </div>
                            <div Class="btn-group">
                                <button type = "button" Class="btn btn-warning">Action</button>
                                <button type = "button" Class="btn btn-warning dropdown-toggle" data-toggle="dropdown">
                                    <span Class="caret"></span>
                                    <span Class="sr-only">Toggle Dropdown</span>
                                </button>
                                <ul Class="dropdown-menu" role="menu">
                                    <li> <a href = "#" > Action</a></li>
                                    <li> <a href = "#" > Another action</a></li>
                                    <li> <a href = "#" > Something Else here</a></li>
                                    <li Class="divider"></li>
                                    <li> <a href = "#" > Separated link</a></li>
                                </ul>
                            </div>
                        </div>
                        <!-- flat split buttons -->
                        <p> Flat split buttons:</p>
                        <div Class="margin">
                            <div Class="btn-group">
                                <button type = "button" Class="btn btn-default btn-flat">Action</button>
                                <button type = "button" Class="btn btn-default btn-flat dropdown-toggle" data-toggle="dropdown">
                                    <span Class="caret"></span>
                                    <span Class="sr-only">Toggle Dropdown</span>
                                </button>
                                <ul Class="dropdown-menu" role="menu">
                                    <li> <a href = "#" > Action</a></li>
                                    <li> <a href = "#" > Another action</a></li>
                                    <li> <a href = "#" > Something Else here</a></li>
                                    <li Class="divider"></li>
                                    <li> <a href = "#" > Separated link</a></li>
                                </ul>
                            </div>
                            <div Class="btn-group">
                                <button type = "button" Class="btn btn-info btn-flat">Action</button>
                                <button type = "button" Class="btn btn-info btn-flat dropdown-toggle" data-toggle="dropdown">
                                    <span Class="caret"></span>
                                    <span Class="sr-only">Toggle Dropdown</span>
                                </button>
                                <ul Class="dropdown-menu" role="menu">
                                    <li> <a href = "#" > Action</a></li>
                                    <li> <a href = "#" > Another action</a></li>
                                    <li> <a href = "#" > Something Else here</a></li>
                                    <li Class="divider"></li>
                                    <li> <a href = "#" > Separated link</a></li>
                                </ul>
                            </div>
                            <div Class="btn-group">
                                <button type = "button" Class="btn btn-danger btn-flat">Action</button>
                                <button type = "button" Class="btn btn-danger btn-flat dropdown-toggle" data-toggle="dropdown">
                                    <span Class="caret"></span>
                                    <span Class="sr-only">Toggle Dropdown</span>
                                </button>
                                <ul Class="dropdown-menu" role="menu">
                                    <li> <a href = "#" > Action</a></li>
                                    <li> <a href = "#" > Another action</a></li>
                                    <li> <a href = "#" > Something Else here</a></li>
                                    <li Class="divider"></li>
                                    <li> <a href = "#" > Separated link</a></li>
                                </ul>
                            </div>
                            <div Class="btn-group">
                                <button type = "button" Class="btn btn-success btn-flat">Action</button>
                                <button type = "button" Class="btn btn-success btn-flat dropdown-toggle" data-toggle="dropdown">
                                    <span Class="caret"></span>
                                    <span Class="sr-only">Toggle Dropdown</span>
                                </button>
                                <ul Class="dropdown-menu" role="menu">
                                    <li> <a href = "#" > Action</a></li>
                                    <li> <a href = "#" > Another action</a></li>
                                    <li> <a href = "#" > Something Else here</a></li>
                                    <li Class="divider"></li>
                                    <li> <a href = "#" > Separated link</a></li>
                                </ul>
                            </div>
                            <div Class="btn-group">
                                <button type = "button" Class="btn btn-warning btn-flat">Action</button>
                                <button type = "button" Class="btn btn-warning btn-flat dropdown-toggle" data-toggle="dropdown">
                                    <span Class="caret"></span>
                                    <span Class="sr-only">Toggle Dropdown</span>
                                </button>
                                <ul Class="dropdown-menu" role="menu">
                                    <li> <a href = "#" > Action</a></li>
                                    <li> <a href = "#" > Another action</a></li>
                                    <li> <a href = "#" > Something Else here</a></li>
                                    <li Class="divider"></li>
                                    <li> <a href = "#" > Separated link</a></li>
                                </ul>
                            </div>
                        </div>
                    </div>
                    <!-- /.box-body -->
                </div>
                <!-- end split buttons box -->
                <!-- social buttons -->
                <div Class="box">
                    <div Class="box-header">
                        <h3 Class="box-title">
                            Social Buttons(By < a href= "https://github.com/lipis/bootstrap-social" > Lipis</a>)
                        </h3>
                    </div>
                    <div Class="box-body">
                        <a Class="btn btn-block btn-social btn-bitbucket">
                            <i Class="fa fa-bitbucket"></i> Sign in with Bitbucket
                        </a>
                        <a Class="btn btn-block btn-social btn-dropbox">
                            <i Class="fa fa-dropbox"></i> Sign in with Dropbox
                        </a>
                        <a Class="btn btn-block btn-social btn-facebook">
                            <i Class="fa fa-facebook"></i> Sign in with Facebook
                        </a>
                        <a Class="btn btn-block btn-social btn-flickr">
                            <i Class="fa fa-flickr"></i> Sign in with Flickr
                        </a>
                        <a Class="btn btn-block btn-social btn-foursquare">
                            <i Class="fa fa-foursquare"></i> Sign in with Foursquare
                        </a>
                        <a Class="btn btn-block btn-social btn-github">
                            <i Class="fa fa-github"></i> Sign in with GitHub
                        </a>
                        <a Class="btn btn-block btn-social btn-google">
                            <i Class="fa fa-google-plus"></i> Sign in with Google
                        </a>
                        <a Class="btn btn-block btn-social btn-instagram">
                            <i Class="fa fa-instagram"></i> Sign in with Instagram
                        </a>
                        <a Class="btn btn-block btn-social btn-linkedin">
                            <i Class="fa fa-linkedin"></i> Sign in with LinkedIn
                        </a>
                        <a Class="btn btn-block btn-social btn-tumblr">
                            <i Class="fa fa-tumblr"></i> Sign in with Tumblr
                        </a>
                        <a Class="btn btn-block btn-social btn-twitter">
                            <i Class="fa fa-twitter"></i> Sign in with Twitter
                        </a>
                        <a Class="btn btn-block btn-social btn-vk">
                            <i Class="fa fa-vk"></i> Sign in with VK
                        </a>
                        <br>
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                    <div Class="text-center">
                            <a Class="btn btn-social-icon btn-bitbucket"><i class="fa fa-bitbucket"></i></a>
                            <a Class="btn btn-social-icon btn-dropbox"><i class="fa fa-dropbox"></i></a>
                            <a Class="btn btn-social-icon btn-facebook"><i class="fa fa-facebook"></i></a>
                            <a Class="btn btn-social-icon btn-flickr"><i class="fa fa-flickr"></i></a>
                            <a Class="btn btn-social-icon btn-foursquare"><i class="fa fa-foursquare"></i></a>
                            <a Class="btn btn-social-icon btn-github"><i class="fa fa-github"></i></a>
                            <a Class="btn btn-social-icon btn-google"><i class="fa fa-google-plus"></i></a>
                            <a Class="btn btn-social-icon btn-instagram"><i class="fa fa-instagram"></i></a>
                            <a Class="btn btn-social-icon btn-linkedin"><i class="fa fa-linkedin"></i></a>
                            <a Class="btn btn-social-icon btn-tumblr"><i class="fa fa-tumblr"></i></a>
                            <a Class="btn btn-social-icon btn-twitter"><i class="fa fa-twitter"></i></a>
                            <a Class="btn btn-social-icon btn-vk"><i class="fa fa-vk"></i></a>
                        </div>
                    </div>
                </div>
                <!-- /.box -->
            </div>
            <!-- /.col -->
            <div Class="col-md-6">
                <!-- Application buttons -->
                <div Class="box">
                    <div Class="box-header">
                        <h3 Class="box-title">Application Buttons</h3>
                    </div>
                    <div Class="box-body">
                        <p> Add the classes <code>.btn.btn-app</code> To an <code>&lt;a></code> tag To achieve the following:</p>
                        <a Class="btn btn-app">
                            <i Class="fa fa-edit"></i> Edit
                        </a>
                        <a Class="btn btn-app">
                            <i Class="fa fa-play"></i> Play
                        </a>
                        <a Class="btn btn-app">
                            <i Class="fa fa-repeat"></i> Repeat
                        </a>
                        <a Class="btn btn-app">
                            <i Class="fa fa-pause"></i> Pause
                        </a>
                        <a Class="btn btn-app">
                            <i Class="fa fa-save"></i> Save
                        </a>
                        <a Class="btn btn-app">
                            <span Class="badge bg-yellow">3</span>
                            <i Class="fa fa-bullhorn"></i> Notifications
                        </a>
                        <a Class="btn btn-app">
                            <span Class="badge bg-green">300</span>
                            <i Class="fa fa-barcode"></i> Products
                        </a>
                        <a Class="btn btn-app">
                            <span Class="badge bg-purple">891</span>
                            <i Class="fa fa-users"></i> Users
                        </a>
                        <a Class="btn btn-app">
                            <span Class="badge bg-teal">67</span>
                            <i Class="fa fa-inbox"></i> Orders
                        </a>
                        <a Class="btn btn-app">
                            <span Class="badge bg-aqua">12</span>
                            <i Class="fa fa-envelope"></i> Inbox
                        </a>
                        <a Class="btn btn-app">
                            <span Class="badge bg-red">531</span>
                            <i Class="fa fa-heart-o"></i> Likes
                        </a>
                    </div>
                    <!-- /.box-body -->
                </div>
                <!-- /.box -->
                <!-- Various colors -->
                <div Class="box">
                    <div Class="box-header">
                        <h3 Class="box-title">Different colors</h3>
                    </div>
                    <div Class="box-body">
                        <p>
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                            Mix And match With various background colors. Use base Class <code>.btn</code> And add any available
                            <code>.bg-*</code> Class
                        </p>
                        <!-- You may notice a .margin class added
                        here but that's only to make the content
                        display correctly without having To use a table-->
                        <p>
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                            <button type = "button" Class="btn bg-maroon btn-flat margin">.btn.bg-maroon.btn-flat</button>
                            <button type = "button" Class="btn bg-purple btn-flat margin">.btn.bg-purple.btn-flat</button>
                            <button type = "button" Class="btn bg-navy btn-flat margin">.btn.bg-navy.btn-flat</button>
                            <button type = "button" Class="btn bg-orange btn-flat margin">.btn.bg-orange.btn-flat</button>
                            <button type = "button" Class="btn bg-olive btn-flat margin">.btn.bg-olive.btn-flat</button>
                        </p>
                        <p>
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                            <button type = "button" Class="btn bg-maroon margin">.btn.bg-maroon</button>
                            <button type = "button" Class="btn bg-purple margin">.btn.bg-purple</button>
                            <button type = "button" Class="btn bg-navy margin">.btn.bg-navy</button>
                            <button type = "button" Class="btn bg-orange margin">.btn.bg-orange</button>
                            <button type = "button" Class="btn bg-olive margin">.btn.bg-olive</button>
                        </p>
                    </div>
                </div>
                <!-- /.box -->
                <!-- Vertical grouping -->
                <div Class="box">
                    <div Class="box-header">
                        <h3 Class="box-title">Vertical Button Group</h3>
                    </div>
                    <div Class="box-body table-responsive pad">
                        <p>
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                            Vertical button groups are easy To create With bootstrap. Just add your buttons
                            inside <code>&lt;div class="btn-group-vertical"&gt;&lt;/div&gt;</code>
                        </p>
                        <table Class="table table-bordered">
                            <tr>
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                <th> Button</th>
                                <th> Icons</th>
                                <th> Flat</th>
                                <th> Dropdown</th>
                            </tr>
                            <!-- Default -->
                            <tr>
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                <td>
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                <div Class="btn-group-vertical">
                                        <button type = "button" Class="btn btn-default">Top</button>
                                        <button type = "button" Class="btn btn-default">Middle</button>
                                        <button type = "button" Class="btn btn-default">Bottom</button>
                                    </div>
                                </td>
                                <td>
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                    <div Class="btn-group-vertical">
                                        <button type = "button" Class="btn btn-default"><i Class="fa fa-align-left"></i></button>
                                        <button type = "button" Class="btn btn-default"><i Class="fa fa-align-center"></i></button>
                                        <button type = "button" Class="btn btn-default"><i Class="fa fa-align-right"></i></button>
                                    </div>
                                </td>
                                <td>
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                        <div Class="btn-group-vertical">
                                        <button type = "button" Class="btn btn-default btn-flat"><i Class="fa fa-align-left"></i></button>
                                        <button type = "button" Class="btn btn-default btn-flat"><i Class="fa fa-align-center"></i></button>
                                        <button type = "button" Class="btn btn-default btn-flat"><i Class="fa fa-align-right"></i></button>
                                    </div>
                                </td>
                                <td>
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                            <div Class="btn-group-vertical">
                                        <button type = "button" Class="btn btn-default">1</button>
                                        <button type = "button" Class="btn btn-default">2</button>
                                        <div Class="btn-group">
                                            <button type = "button" Class="btn btn-default dropdown-toggle" data-toggle="dropdown">
                                                <span Class="caret"></span>
                                            </button>
                                            <ul Class="dropdown-menu">
                                                <li> <a href = "#" > Dropdown link</a></li>
                                                <li> <a href = "#" > Dropdown link</a></li>
                                            </ul>
                                        </div>
                                    </div>
                                </td>
                            </tr>
                            <!-- ./default -->
                            <!-- Info -->
                            <tr>
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                            <td>
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                            <div Class="btn-group-vertical">
                                        <button type = "button" Class="btn btn-info">Top</button>
                                        <button type = "button" Class="btn btn-info">Middle</button>
                                        <button type = "button" Class="btn btn-info">Bottom</button>
                                    </div>
                                </td>
                                <td>
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                <div Class="btn-group-vertical">
                                        <button type = "button" Class="btn btn-info"><i Class="fa fa-align-left"></i></button>
                                        <button type = "button" Class="btn btn-info"><i Class="fa fa-align-center"></i></button>
                                        <button type = "button" Class="btn btn-info"><i Class="fa fa-align-right"></i></button>
                                    </div>
                                </td>
                                <td>
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                    <div Class="btn-group-vertical">
                                        <button type = "button" Class="btn btn-info btn-flat"><i Class="fa fa-align-left"></i></button>
                                        <button type = "button" Class="btn btn-info btn-flat"><i Class="fa fa-align-center"></i></button>
                                        <button type = "button" Class="btn btn-info btn-flat"><i Class="fa fa-align-right"></i></button>
                                    </div>
                                </td>
                                <td>
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                        <div Class="btn-group-vertical">
                                        <button type = "button" Class="btn btn-info">1</button>
                                        <button type = "button" Class="btn btn-info">2</button>
                                        <div Class="btn-group">
                                            <button type = "button" Class="btn btn-info dropdown-toggle" data-toggle="dropdown">
                                                <span Class="caret"></span>
                                            </button>
                                            <ul Class="dropdown-menu">
                                                <li> <a href = "#" > Dropdown link</a></li>
                                                <li> <a href = "#" > Dropdown link</a></li>
                                            </ul>
                                        </div>
                                    </div>
                                </td>
                            </tr>
                            <!-- /. info -->
                            <!-- /.danger -->
                            <tr>
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                        <td>
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                        <div Class="btn-group-vertical">
                                        <button type = "button" Class="btn btn-danger">Top</button>
                                        <button type = "button" Class="btn btn-danger">Middle</button>
                                        <button type = "button" Class="btn btn-danger">Bottom</button>
                                    </div>
                                </td>
                                <td>
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                            <div Class="btn-group-vertical">
                                        <button type = "button" Class="btn btn-danger"><i Class="fa fa-align-left"></i></button>
                                        <button type = "button" Class="btn btn-danger"><i Class="fa fa-align-center"></i></button>
                                        <button type = "button" Class="btn btn-danger"><i Class="fa fa-align-right"></i></button>
                                    </div>
                                </td>
                                <td>
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                <div Class="btn-group-vertical">
                                        <button type = "button" Class="btn btn-danger btn-flat"><i Class="fa fa-align-left"></i></button>
                                        <button type = "button" Class="btn btn-danger btn-flat"><i Class="fa fa-align-center"></i></button>
                                        <button type = "button" Class="btn btn-danger btn-flat"><i Class="fa fa-align-right"></i></button>
                                    </div>
                                </td>
                                <td>
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                    <div Class="btn-group-vertical">
                                        <button type = "button" Class="btn btn-danger">1</button>
                                        <button type = "button" Class="btn btn-danger">2</button>
                                        <div Class="btn-group">
                                            <button type = "button" Class="btn btn-danger dropdown-toggle" data-toggle="dropdown">
                                                <span Class="caret"></span>
                                            </button>
                                            <ul Class="dropdown-menu">
                                                <li> <a href = "#" > Dropdown link</a></li>
                                                <li> <a href = "#" > Dropdown link</a></li>
                                            </ul>
                                        </div>
                                    </div>
                                </td>
                            </tr>
                            <!-- /.danger -->
                            <!-- warning -->
                            <tr>
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                    <td>
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                    <div Class="btn-group-vertical">
                                        <button type = "button" Class="btn btn-warning">Top</button>
                                        <button type = "button" Class="btn btn-warning">Middle</button>
                                        <button type = "button" Class="btn btn-warning">Bottom</button>
                                    </div>
                                </td>
                                <td>
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                        <div Class="btn-group-vertical">
                                        <button type = "button" Class="btn btn-warning"><i Class="fa fa-align-left"></i></button>
                                        <button type = "button" Class="btn btn-warning"><i Class="fa fa-align-center"></i></button>
                                        <button type = "button" Class="btn btn-warning"><i Class="fa fa-align-right"></i></button>
                                    </div>
                                </td>
                                <td>
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                            <div Class="btn-group-vertical">
                                        <button type = "button" Class="btn btn-warning btn-flat"><i Class="fa fa-align-left"></i></button>
                                        <button type = "button" Class="btn btn-warning btn-flat"><i Class="fa fa-align-center"></i></button>
                                        <button type = "button" Class="btn btn-warning btn-flat"><i Class="fa fa-align-right"></i></button>
                                    </div>
                                </td>
                                <td>
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                <div Class="btn-group-vertical">
                                        <button type = "button" Class="btn btn-warning">1</button>
                                        <button type = "button" Class="btn btn-warning">2</button>
                                        <div Class="btn-group">
                                            <button type = "button" Class="btn btn-warning dropdown-toggle" data-toggle="dropdown">
                                                <span Class="caret"></span>
                                            </button>
                                            <ul Class="dropdown-menu">
                                                <li> <a href = "#" > Dropdown link</a></li>
                                                <li> <a href = "#" > Dropdown link</a></li>
                                            </ul>
                                        </div>
                                    </div>
                                </td>
                            </tr>
                            <!-- /.warning -->
                            <!-- success -->
                            <tr>
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                <td>
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                <div Class="btn-group-vertical">
                                        <button type = "button" Class="btn btn-success">Top</button>
                                        <button type = "button" Class="btn btn-success">Middle</button>
                                        <button type = "button" Class="btn btn-success">Bottom</button>
                                    </div>
                                </td>
                                <td>
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                    <div Class="btn-group-vertical">
                                        <button type = "button" Class="btn btn-success"><i Class="fa fa-align-left"></i></button>
                                        <button type = "button" Class="btn btn-success"><i Class="fa fa-align-center"></i></button>
                                        <button type = "button" Class="btn btn-success"><i Class="fa fa-align-right"></i></button>
                                    </div>
                                </td>
                                <td>
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                        <div Class="btn-group-vertical">
                                        <button type = "button" Class="btn btn-success btn-flat"><i Class="fa fa-align-left"></i></button>
                                        <button type = "button" Class="btn btn-success btn-flat"><i Class="fa fa-align-center"></i></button>
                                        <button type = "button" Class="btn btn-success btn-flat"><i Class="fa fa-align-right"></i></button>
                                    </div>
                                </td>
                                <td>
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                            <div Class="btn-group-vertical">
                                        <button type = "button" Class="btn btn-success">1</button>
                                        <button type = "button" Class="btn btn-success">2</button>
                                        <div Class="btn-group">
                                            <button type = "button" Class="btn btn-success dropdown-toggle" data-toggle="dropdown">
                                                <span Class="caret"></span>
                                            </button>
                                            <ul Class="dropdown-menu">
                                                <li> <a href = "#" > Dropdown link</a></li>
                                                <li> <a href = "#" > Dropdown link</a></li>
                                            </ul>
                                        </div>
                                    </div>
                                </td>
                            </tr>
                            <!-- /.success -->
                        </table>
                    </div>
                    <!-- /.box-body -->
                </div>
                <!-- /.box -->
            </div>
            <!-- /.col -->
        </div>
        <!-- /. row -->
    </section>
    <!-- /.content -->
</div>
<!-- /.content-wrapper -->

