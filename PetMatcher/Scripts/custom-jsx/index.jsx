var HomePage = React.createClass({
    render: function () {
        return (
            <div>Hello {this.props.name}</div>
            );
    }

});

React.render( <HomePage name="World" />, document.getElementById('container'));