from flask import Flask, render_template, request
app = Flask(__name__)

@app.route('/', methods=['POST', 'GET'])
def index():
    if request.method == 'GET':
        return render_template('formindex.html')
    else:
        inputtedName = request.form.get("fullname")
        sushiAnswer = request.form.get("sushi")
        vehicleAnswer = request.form.get("vehicle")
        formAnswer = request.form.getlist('vehicle')
        return render_template('results.html', name=inputtedName, sushiA=sushiAnswer, vehicle=vehicleAnswer, formAnswer=formAnswer)
